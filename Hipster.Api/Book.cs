using System.ComponentModel.DataAnnotations;

namespace Hipster.Api
{
    public class Book
    {
        [Required]
        public int Id { get; init; }

        [Required]
        public string Title { get; init; }

        [Required]
        public string Author { get; init; }

        [Required]
        public string ISBN { get; init; }

        [Required]
        public int Year { get; init; }

        [Required]
        public string Description { get; init; }

        [Required]
        public string CoverImageUrl { get; init; }
    }
}