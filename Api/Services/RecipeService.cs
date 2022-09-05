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

        public RecipeService(IRecipeRepository repository, IUnitOfWork unitOfWork)
        {
            _recipeRepository = repository;
            _unitOfWork = unitOfWork;
        }
        public async Task Create(RecipeDto recipeDto)
        {
            if (recipeDto == null)
            {
                throw new Exception($"{nameof(Recipe)} not found");
            }

            IRecipeBuilder recipeBuilder = new RecipeBuilder();
            RecipeDirector recipeDirector = new(recipeBuilder);
            recipeDirector.Construct(recipeDto);
            Recipe recipeEntity = recipeBuilder.GetResult();

            await _recipeRepository.Create(recipeEntity);

            await _unitOfWork.SaveEntitiesAsync();
        }

        public async Task Delete(int recipeId)
        {
            await _recipeRepository.Delete(recipeId);

            await _unitOfWork.SaveEntitiesAsync();
        }

        public async Task<RecipeDto> Get(int recipeId)
        {
            Recipe recipe = await _recipeRepository.Get(recipeId);
            if (recipe == null)
            {
                throw new Exception($"{nameof(Recipe)} not found, #Id - {recipeId}");
            }

            return recipe.MapToRecipeDto();
        }

        public async Task<List<RecipeShortDto>> GetAll()
        {
            List<Recipe> recipes = await _recipeRepository.GetAll();
            return recipes.ConvertAll(x => x.MapToRecipeShortDto());
        }

        public async Task<RecipeBestDto> GetBestRecipe()
        {
            throw new NotImplementedException();
        }

        public async Task<List<RecipeShortDto>> GetByTag(int tagId)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveFavorite(int recipeId, int userId)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveLike(int recipeId, int userId)
        {
            await _recipeRepository.RemoveLike(recipeId, userId);
        }

        public async Task SetFavorite(int recipeId, int userId)
        {
            await _recipeRepository.SetFavorite(recipeId, userId);
        }

        public async Task SetLike(int recipeId, int userId)
        {
            await _recipeRepository.SetLike(recipeId, userId);
        }

        public async Task Update(RecipeDto recipeDto)
        {
            if(recipeDto == null)
            {
                throw new Exception($"{nameof(Recipe)} not found");
            }

            IRecipeBuilder recipeBuilder = new RecipeBuilder();
            RecipeDirector recipeDirector = new(recipeBuilder);
            recipeDirector.Construct(recipeDto);
            Recipe recipeEntity = recipeBuilder.GetResult();

            _recipeRepository.Update(recipeEntity);

            await _unitOfWork.SaveEntitiesAsync();
        }
    }
}
