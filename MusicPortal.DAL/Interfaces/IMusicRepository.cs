using MusicPortal.DAL.Entities;
using MusicPortal.DAL.ViewModel;

namespace MusicPortal.DAL.Interfaces
{
    internal interface IMusicRepository<T> where T : class
    {
        Task<IEnumerable<Music>> GetAllMusic();
        Task<IEnumerable<Music>> GetAllMusicUserAdmin();
        Task AddMusic(MusicViewModel model, byte[] fileData);
        Task UpdateMusic(Music music, byte[] fileData = null);
        Task DeleteMusic(int id);
        Task<Music> GetMusicById(int id);
    }
}
