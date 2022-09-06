namespace Api.Dto
{
    public record RecipeBestDto(
        int Id,
        string Title,
        string Description,
        int CookingMinutes,
        string Image,
        int CountOfLikes);
}
