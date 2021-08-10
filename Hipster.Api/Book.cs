namespace Hipster.Api
{
    public class Book
    {
        public int Id { get; init; }

        public string Title { get; init; }

        public string Author { get; init; }

        public string ISBN { get; init; }

        public int Year { get; init; }

        public string Description { get; init; }

        public string CoverImageUrl { get; init; }
    }
}