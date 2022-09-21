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

        public async Task RemoveFavorite(FavoriteDto favoriteDto)
        {
            Favorite favorite = await _recipeRepository.GetFavorite(favoriteDto.RecipeId, favoriteDto.UserId);
            if (favorite == null)
            {
                throw new Exception($"{nameof(Favorite)} not found, #RecipeId - {favoriteDto.RecipeId} #UserId - {favoriteDto.RecipeId}");
            }
            _recipeRepository.RemoveFavorite(favorite);

            await _unitOfWork.SaveEntitiesAsync();
        }

        public async Task RemoveLike(LikeDto likeDto)
        {
            Like like = await _recipeRepository.GetLike(likeDto.RecipeId, likeDto.UserId);
            if (like == null)
            {
                throw new Exception($"{nameof(Like)} not found, #RecipeId - {likeDto.RecipeId} #UserId - {likeDto.UserId}");
            }
            _recipeRepository.RemoveLike(like);

            await _unitOfWork.SaveEntitiesAsync();
        }

        public async Task AddFavorite(FavoriteDto favoriteDto)
        {
            await _recipeRepository.AddFavorite(favoriteDto.MapToFavorite());

            await _unitOfWork.SaveEntitiesAsync();
        }

        public async Task AddLike(LikeDto likeDto)
        {
            await _recipeRepository.AddLike(likeDto.MapToLike());

            await _unitOfWork.SaveEntitiesAsync();
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
