﻿namespace NetflixAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Length { get; set; }
        public byte Rating { get; set; }
        public string Category { get; set; }
    }
}
