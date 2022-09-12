using Api.Dto;
using Domain.RecipeEntity;
using Domain.UoW;
using Api.Services.Mappers;
using Api.Services.Builders;

namespace Api.Services
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRecipeBuilder _recipeBuilder;

        public RecipeService(IRecipeRepository repository, IUnitOfWork unitOfWork, IRecipeBuilder recipeBuilder)
        {
            _recipeRepository = repository;
            _unitOfWork = unitOfWork;
            _recipeBuilder = recipeBuilder;
        }

        public async Task Delete(int recipeId)
        {
            Recipe recipe = await _recipeRepository.Get(recipeId);
            if (recipe == null)
            {
                throw new Exception($"{nameof(Recipe)} not found, #Id - {recipeId}");
            }
            _recipeRepository.Delete(recipe);

            await _unitOfWork.SaveEntitiesAsync();
        }

        public async Task<RecipeEditDto> Get(int recipeId)
        {
            Recipe recipe = await _recipeRepository.Get(recipeId);
            if (recipe == null)
            {
                throw new Exception($"{nameof(Recipe)} not found, #Id - {recipeId}");
            }

            return recipe.MapToRecipeEditDto();
        }

        public async Task<List<RecipeDto>> GetAll()
        {
            List<Recipe> recipes = await _recipeRepository.GetRecipes();
            return recipes.ConvertAll(x => x.MapToRecipeDto());
        }

        public async Task<RecipeBestDto> GetBestRecipe()
        {
            throw new NotImplementedException();
        }

        public async Task<List<RecipeDto>> GetByTag(int tagId)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveFavorite(int recipeId, int userId)
        {
            Favorite favorite = await _recipeRepository.GetFavorite(recipeId, userId);
            if (favorite == null)
            {
                throw new Exception($"{nameof(Favorite)} not found, #RecipeId - {recipeId} #UserId - {userId}");
            }
            _recipeRepository.RemoveFavorite(favorite);
        }

        public async Task RemoveLike(int recipeId, int userId)
        {
            Like like = await _recipeRepository.GetLike(recipeId, userId);
            if (like == null)
            {
                throw new Exception($"{nameof(Like)} not found, #RecipeId - {recipeId} #UserId - {userId}");
            }
            _recipeRepository.RemoveLike(like);
        }

        public async Task SetFavorite(int recipeId, int userId)
        {
            await _recipeRepository.SetFavorite(new Favorite(userId, recipeId));
        }

        public async Task SetLike(int recipeId, int userId)
        {
            await _recipeRepository.SetLike(new Like(userId, recipeId));
        }

        public async Task Save(RecipeEditDto recipeDto)
        {
            if (recipeDto == null)
            {
                throw new Exception($"{nameof(RecipeEditDto)} not found");
            }

            Recipe recipe = (await _recipeBuilder.BuildAll(recipeDto)).GetResult();

            if(recipe.Id == 0)
            {
                await _recipeRepository.Create(recipe);
            }

            await _unitOfWork.SaveEntitiesAsync();
        }
    }
}
