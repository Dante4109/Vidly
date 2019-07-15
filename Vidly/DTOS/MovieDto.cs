﻿using System;
using System.ComponentModel.DataAnnotations;
using Vidly.DTOS;

namespace Vidly.DTOS
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 50)]
        public byte NumberInStock { get; set; }
    }
}

