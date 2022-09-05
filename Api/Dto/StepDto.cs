namespace Api.Dto
{
    public record StepDto(
        int Id,
        int OrderNumber,
        string Description,
        int RecipeId)
    {
    }
}
