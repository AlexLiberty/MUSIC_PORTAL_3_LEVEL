﻿using MusicPortal.DAL.EF;
using MusicPortal.DAL.Entities;
using MusicPortal.DAL.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MusicPortal.DAL.Repositories
{
    internal class GenreRepository : IGenreRepository<Genre>
    {
        private readonly MusicPortalContext _context;

        public GenreRepository(MusicPortalContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Genre>> GetAllGenres()
        {
            return await _context.Genres.ToListAsync();
        }

        public async Task<bool> AddGenre(string name)
        {
            var genreExists = _context.Genres
                .AsEnumerable()
                .Any(g => g.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (genreExists || name == null)
            {
                return false;
            }

            var genre = new Genre { Name = name };
            _context.Genres.Add(genre);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task UpdateGenre(Genre genre)
        {
            _context.Genres.Update(genre);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteGenre(int id)
        {
            var genre = await _context.Genres.FindAsync(id);
            if (genre != null)
            {
                _context.Genres.Remove(genre);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Genre> GetGenreById(int id)
        {
            return await _context.Genres.FindAsync(id);
        }
    }
}
