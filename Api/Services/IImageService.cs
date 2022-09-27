namespace Api.Services
{
    public interface IImageService
    {
        void DeleteImage(string imageName);
        Task<string> SaveImage(IFormFile image);
        Task<string> GetDtoImage(string imageName);
    }
}