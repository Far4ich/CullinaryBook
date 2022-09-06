using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record FavoriteDto(
        [Required]
        int UserId,
        [Required]
        int RecipeId);
}
