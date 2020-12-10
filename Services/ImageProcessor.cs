using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace MedelLibrary.Services
{
    public class ImageProcessor : IImage
    {
        private readonly IHostingEnvironment _hostingEnvironment;

        public ImageProcessor(IHostingEnvironment hostingEnvironment)
        {
            this._hostingEnvironment = hostingEnvironment;
        }

        public string SaveImage(IFormFile image, string saveto)
        {
            string uniqueFileName = "";

            if (image != null)
            {
                string UploadsFolder = Path.Combine(this._hostingEnvironment.WebRootPath, saveto);
                uniqueFileName = (Guid.NewGuid().ToString() + "_" + image.FileName).Trim();
                string filePath = Path.Combine(UploadsFolder, uniqueFileName);
                image.CopyTo(new FileStream(filePath, FileMode.Create));
            }
            return uniqueFileName;
        }
    }
}