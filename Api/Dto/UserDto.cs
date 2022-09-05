namespace Api.Dto
{
    public record UserDto(
        int Id,
        string Name,
        string Login,
        string Password,
        string AsboutMe)
    {
    }
}
