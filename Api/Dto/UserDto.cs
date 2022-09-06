using System.ComponentModel.DataAnnotations;

namespace Api.Dto
{
    public record UserDto(
        int Id,
        [Required]
        [MaxLength(50)]
        string Name,
        [Required]
        [MaxLength(20)]
        string Login,
        [Required]
        [MaxLength(100)]
        string Password,
        [MaxLength(255)]
        string AsboutMe)
    {
    }
}
