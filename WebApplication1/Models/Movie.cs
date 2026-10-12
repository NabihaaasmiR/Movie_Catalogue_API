using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        [StringLength(150, ErrorMessage = "Title cannot exceed 150 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Genre is required.")]
        public string Genre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Language is required.")]
        public string Language { get; set; } = string.Empty;

        [Range(1, 600, ErrorMessage = "Duration must be a positive integer between 1 and 600 minutes.")]
        public int DurationMinutes { get; set; }

        [Range(1888, 2100, ErrorMessage = "Release year must be a valid year.")]
        public int ReleaseYear { get; set; }
    }
}