﻿using System;
using System.ComponentModel.DataAnnotations;

namespace webapplication.Data
{


    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ReleaseDate { get; set; }
        public float? Rate { get; set; }
        public string? ImageUrl { get; set; }
    }
}
