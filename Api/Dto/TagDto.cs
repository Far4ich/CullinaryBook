using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record TagDto(
        int Id,
        [Required]
        [MaxLength(50)]
        string Title)
    {
    }
}
