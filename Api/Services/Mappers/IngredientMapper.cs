using Api.Dto;
using Domain.RecipeEntity;

namespace Api.Services.Mappers
{
    public static class IngredientMapper
    {
        public static IngredientDto MapToIngredientDto(this Ingredient ingredient)
        {
            return new IngredientDto(
                ingredient.Id,
                ingredient.Title,
                ingredient.OrderNumber,
                ingredient.Products,
                ingredient.RecipeId);
        }
        public static Ingredient MapToIngredient(this IngredientDto ingredient)
        {
            return new Ingredient(
                ingredient.Title,
                ingredient.OrderNumber,
                ingredient.Products,
                ingredient.RecipeId);
        }
    }
}
