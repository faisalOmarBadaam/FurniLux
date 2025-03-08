using FurniLux.Models;

namespace FurniLux.Tools
{
    public static class FileTools
    {

        public static async Task CopyPhotoToEnviroment(Product product, IWebHostEnvironment _env, IFormFile image)
        {
            var uploadsFolder = Path.Combine(_env.WebRootPath, "images");
            var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await image.CopyToAsync(fileStream);
            }
            product.ImageUrl = uniqueFileName;
        }

        public static void DeletePhoto(IWebHostEnvironment _env, string ImageName)
        {
            System.IO.File.Delete(_env.WebRootPath + "\\images\\" + ImageName);
        }
    }
}
