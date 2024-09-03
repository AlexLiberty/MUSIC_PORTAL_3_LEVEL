using MusicPortal.DAL.Entities;

namespace MusicPortal.DAL.Interfaces
{
    internal interface IUnitOfWork
    {
        IUserRepository<User> Users { get; }
        IGenreRepository<Genre> Genres { get; }
        IMusicRepository<Music> Music { get; }
        Task Save();
    }
}

