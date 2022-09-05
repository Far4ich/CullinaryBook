namespace Api.Dto
{
    public record IngredientDto(
        int Id,
        string Title,
        int OrderNumber,
        string Products, 
        int RecipeId) 
    {
    }
}
