using Microsoft.AspNetCore.Http;

namespace MusicPortal.DAL.ViewModel
{
    internal class MusicViewModel
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public int GenreId { get; set; }
        public IFormFile MusicFile { get; set; }
    }
}
