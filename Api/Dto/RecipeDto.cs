namespace Api.Dto
{
    public record RecipeDto(
        int Id,
        string Title,
        string Description,
        int CookingMinutes,
        int NumberOfServings,
        string Image,
        int AuthorId,
        List<TagDto> Tags,
        int CountOfLikes,
        int CountOfFavorites);
}
