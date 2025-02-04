﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace MusicPortal.DAL.Entities
{
    public class Music
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Artist { get; set; }
        public string? FilePath { get; set; }
        [NotMapped]
        public IFormFile? MusicFile { get; set; }
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
    }
}
