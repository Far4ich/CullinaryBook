using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record FavoriteDto(
        int Id,
        [Required]
        int UserId,
        [Required]
        int RecipeId)
    {
    }
}
