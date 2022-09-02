using Api.Dto;
using Domain.RecipeEntity;
using Domain.UoW;
using Api.Mappers;

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
        public void Create(RecipeFullDto recipeFullDto)
        {
            if (recipeFullDto == null)
            {
                throw new Exception($"{nameof(Recipe)} not found");
            }

            Recipe recipeEntity = recipeFullDto.MapToRecipe();

            _recipeRepository.Create(recipeEntity);

            _unitOfWork.SaveEntitiesAsync();
        }

        public void Delete(int recipeId)
        {
            _recipeRepository.Delete(recipeId);

            _unitOfWork.SaveEntitiesAsync();
        }

        public RecipeFullDto Get(int recipeId)
        {
            Recipe recipe = _recipeRepository.Get(recipeId).Result;
            if (recipe == null)
            {
                throw new Exception($"{nameof(Recipe)} not found, #Id - {recipeId}");
            }

            return recipe.MapToRecipeFullDto();
        }

        public List<RecipeListDto> GetAll()
        {
            List<Recipe> recipes = _recipeRepository.GetAll().Result;
            return recipes.ConvertAll(x => x.MapToRecipeListDto());
        }

        public RecipeBestDto GetBestRecipe()
        {
            throw new NotImplementedException();
        }

        public List<RecipeListDto> GetByTag(int tagId)
        {
            throw new NotImplementedException();
        }

        public void RemoveFavorite(int recipeId, int userId)
        {
            throw new NotImplementedException();
        }

        public void RemoveLike(int recipeId, int userId)
        {
            _recipeRepository.RemoveLike(recipeId, userId);
        }

        public void SetFavorite(int recipeId, int userId)
        {
            _recipeRepository.SetFavorite(recipeId, userId);
        }

        public void SetLike(int recipeId, int userId)
        {
            _recipeRepository.SetLike(recipeId, userId);
        }

        public void Update(RecipeFullDto recipe)
        {
            if(recipe == null)
            {
                throw new Exception($"{nameof(Recipe)} not found");
            }
            _recipeRepository.Update(recipe.MapToRecipe());
        }
    }
}
