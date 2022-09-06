using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record IngredientDto(
        int Id,
        [Required]
        [MaxLength(50)]
        string Title,
        [Required]
        int OrderNumber,
        [Required]
        [MaxLength(511)]
        string Products,
        [Required]
        int RecipeId);
}
