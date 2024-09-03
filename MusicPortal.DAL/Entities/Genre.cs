﻿using System.ComponentModel.DataAnnotations;

namespace MusicPortal.DAL.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
