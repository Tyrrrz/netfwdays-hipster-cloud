using Microsoft.EntityFrameworkCore;

namespace Hipster.Api
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Book> Books { get; init; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Lord of the Rings",
                    Author = "J.R.R. Tolkien",
                    ISBN = "123456789",
                    Year = 1954,
                    Description = "A great book!",
                    CoverImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e9/First_Single_Volume_Edition_of_The_Lord_of_the_Rings.gif"
                },

                new Book
                {
                    Id = 2,
                    Title = "Harry Potter",
                    Author = "J.K. Rowling",
                    ISBN = "987654321",
                    Year = 1997,
                    Description = "A great book!",
                    CoverImageUrl = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1474154022l/3._SY475_.jpg"
                },

                new Book
                {
                    Id = 3,
                    Title = "Lonely Planet",
                    Author = "Tom De Smedt",
                    ISBN = "123456789",
                    Year = 2004,
                    Description = "A great book!",
                    CoverImageUrl = "https://images-na.ssl-images-amazon.com/images/I/51rV%2BQ%2BKL.jpg"
                }
            );
        }
    }
}