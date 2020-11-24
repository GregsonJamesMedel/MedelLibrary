using Microsoft.AspNetCore.Http;

namespace MedelLibrary.Services
{
    public interface IImage
    {
        string SaveImage(IFormFile image);
    }
}