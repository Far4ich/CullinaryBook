using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record RecipeFullDto(
        int Id,
        [Required]
        [MaxLength(50)]
        string Title,
        [Required]
        [MaxLength(150)]
        string Description,
        [Required]
        [Range(1, 180)]
        int CookingMinutes,
        [Required]
        [Range(1, 100)]
        int NumberOfServings,
        string Image,
        [Required]
        int AuthorId,
        List<TagDto> Tags,
        List<IngredientDto> Ingredients,
        List<StepDto> Steps);
}
