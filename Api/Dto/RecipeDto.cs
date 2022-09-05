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
        List<TagDto> TagDtos,
        List<LikeDto> LikeDtos,
        List<FavoriteDto> FavoriteDtos,
        List<IngredientDto> IngredientDtos,
        List<StepDto> StepDtos)
    {
    }
}
