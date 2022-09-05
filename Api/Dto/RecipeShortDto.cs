namespace Api.Dto
{
    public record RecipeShortDto(
        int Id,
        string Title,
        string Description,
        int CookingMinutes,
        int NumberOfServings,
        string Image,
        int AuthorId,
        List<TagDto> Tags,
        List<LikeDto> Likes,
        List<FavoriteDto> Favorites)
    {
    }
}
