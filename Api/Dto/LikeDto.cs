using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record LikeDto(
        int Id,
        [Required]
        int UserId,
        [Required]
        int RecipeId)
    {
    }
}
