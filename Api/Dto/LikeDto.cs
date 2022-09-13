using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record LikeDto(
        [Required]
        int UserId,
        [Required]
        int RecipeId);
}
