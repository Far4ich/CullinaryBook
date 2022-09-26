using Domain.RecipeEntity;

namespace Api.Services
{
    public class ImageService : IImageService
    {
        private readonly string _imagesPath = "C:\\Users\\Alex\\Desktop\\Practice\\SaveImages";
        public async Task<string> SaveImage(string image)
        {
            string imageFormat = image[(image.IndexOf("/") + 1)..image.IndexOf(";")];
            string imageName = Path.ChangeExtension(Path.GetRandomFileName(), imageFormat);
            string imagePath = Path.Combine(_imagesPath, imageName);

            byte[] bytes = Convert.FromBase64String(image[(image.IndexOf(",") + 1)..]);
            FileStream fs = new(imagePath, FileMode.Create);
            await fs.WriteAsync(bytes);
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
