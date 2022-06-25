﻿using System.ComponentModel.DataAnnotations.Schema;

namespace RestApi.Model
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender    { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public ICollection<Album> Albums { get; set; }
        public ICollection<Song> Songs { get; set; }    

    }
}
