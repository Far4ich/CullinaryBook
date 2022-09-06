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
        public async Task Create(RecipeEditDto recipeDto)
        {
            if (recipeDto == null)
            {
                throw new Exception($"{nameof(Recipe)} not found");
            }

            Recipe recipeEntity = _recipeBuilder
                .BuildNewRecipe()
                .BuildRecipeData(recipeDto)
                .GetResult();

            await _recipeRepository.Create(recipeEntity);

            await _unitOfWork.SaveEntitiesAsync();
        }

        public async Task Delete(int recipeId)
        {
            await _recipeRepository.Delete(recipeId);

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
            List<Recipe> recipes = await _recipeRepository.GetAll();
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

        public async Task Update(RecipeEditDto recipeDto)
        {
            if(recipeDto == null)
            {
                throw new Exception($"{nameof(RecipeEditDto)} not found");
            }

            Recipe recipeEntity = await _recipeRepository.Get(recipeDto.Id);

            recipeEntity = _recipeBuilder
                .BuildRecipeForUpdate(recipeEntity)
                .BuildRecipeData(recipeDto)
                .GetResult();

            _recipeRepository.Update(recipeEntity);

            await _unitOfWork.SaveEntitiesAsync();
        }
    }
}
