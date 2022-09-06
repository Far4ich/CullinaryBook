using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record StepDto(
        int Id,
        [Required]
        int OrderNumber,
        [Required]
        [MaxLength(511)]
        string Description,
        [Required]
        int RecipeId);
}
