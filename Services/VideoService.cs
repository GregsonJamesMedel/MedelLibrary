using MedelLibrary.Data;
using MedelLibrary.Models;

namespace MedelLibrary.Services
{
    public class VideoService : IVideo
    {
        private readonly DataContext _context;

        public VideoService(DataContext context)
        {
            this._context = context;
        }

        public bool AddVideo(Video video)
        {
            this._context.LibraryAsset.Add(video);
            var result = this._context.SaveChanges();
            return result > 0 ? true : false;
        }
    }
}