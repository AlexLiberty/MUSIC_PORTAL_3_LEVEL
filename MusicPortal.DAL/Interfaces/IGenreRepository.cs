using MusicPortal.DAL.Entities;

namespace MusicPortal.DAL.Interfaces
{
    internal interface IGenreRepository<T> where T : class
    {
        Task<bool> AddGenre(string name);
        Task UpdateGenre(Genre genre);
        Task DeleteGenre(int id);
        Task<Genre> GetGenreById(int id);
        Task<IEnumerable<Genre>> GetAllGenres();
    }
}
