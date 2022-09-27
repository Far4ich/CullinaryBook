using Domain.RecipeEntity;
using Microsoft.AspNetCore.Http;

namespace Api.Services
{
    public class ImageService : IImageService
    {
        private readonly string _imagesPath;

        public ImageService(IConfiguration configuration)
        {
            _imagesPath = configuration.GetValue<string>("ImagesPath");
        }

        public async Task<string> SaveImage(IFormFile image)
        {
            string imageFormat = image.ContentType[(image.ContentType.IndexOf("/") + 1)..];
            string imageName = Path.ChangeExtension(Path.GetRandomFileName(), imageFormat);
            string imagePath = Path.Combine(_imagesPath, imageName);

            FileStream fs = new(imagePath, FileMode.Create);
            await image.CopyToAsync(fs);
            fs.Close();

            return imageName;
        }

        public void DeleteImage(string imageName)
        {
            string path = Path.Combine(_imagesPath, imageName);
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

        public async Task<string> GetDtoImage(string imageName)
        {
            if (!string.IsNullOrEmpty(imageName))
            {
                string path = Path.Combine(_imagesPath, imageName);
                if (File.Exists(path))
                {
                    FileStream fs = new(path, FileMode.Open);
                    byte[] buffer = new byte[fs.Length]; ;
                    await fs.ReadAsync(buffer, 0, (int)fs.Length);
                    fs.Close();
                    return "data:image/" + Path.GetExtension(imageName).Trim('.') + ";base64," + Convert.ToBase64String(buffer);
                }
                throw new Exception("Image not found with image name - " + imageName);
            }
            return imageName;
        }
    }
}
