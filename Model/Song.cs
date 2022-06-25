using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestApi.Model
{
    public class Song
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title Can't be null or empty")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Language Can't be null or empty")]
        public string Duration { get; set; }
        [Required(ErrorMessage = "Kindly provide the song duration")]
        public DateTime UploadedDate { get; set; }
        public bool IsFeatured { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile AudioFile { get; set; }
        public string AudioUrl { get; set; }
        public int ArtistId { get; set; }
        public int? AlbumId { get; set; }
    }
}
