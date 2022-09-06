using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record TagDto(
        [Required]
        [MaxLength(50)]
        string Title);
}
