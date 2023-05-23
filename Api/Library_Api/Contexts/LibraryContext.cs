using Library_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Library_Api.Contexts
{
    public class LibraryContext : DbContext
    {
        public LibraryContext() { }
        public LibraryContext(DbContextOptions<LibraryContext> options) : base (options) { }

        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,4)");
            
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = 1,
                    Name = "Jonathan Swift"
                },
                new Author
                {
                    AuthorId = 2,
                    Name = "Robert Louis Steverson"
                },
                new Author
                {
                    AuthorId = 3,
                    Name = "J. K. Rowling"
                },        
                new Author
                {
                    AuthorId = 4,
                    Name = "Jennifer Niven"
                },
                new Author
                {
                    AuthorId = 5,
                    Name = "Stephen King"
                },
                new Author
                {
                    AuthorId = 6,
                    Name = "Coolen Hover"
                },
                new Author
                {
                    AuthorId = 7,
                    Name = "Charlie Donlea"
                }          
            );

            modelBuilder.Entity<Book>().HasData(
                new {
                    BookId = 1,
                    Name = "Gulliver's Travels",
                    YearLauch = "1726",
                    Edition = 1,
                    PublishingCompany = "Pearson English",
                    UrlWebImg = "https://m.media-amazon.com/images/I/51W6w1PrkbL._SX384_BO1,204,203,200_.jpg",
                    Price = 59M,
                    AuthorId = 1         
                },
                new {
                    BookId = 2,
                    Name = "Dr Jekyll & Mr Hyde",
                    YearLauch = "1982",
                    Edition = 3,
                    PublishingCompany = "Bantam Books",
                    UrlWebImg = "https://m.media-amazon.com/images/I/71F0gmdm8pL.jpg",
                    Price = 53.91M,
                    AuthorId = 2
                },
                new {
                    BookId = 3,
                    Name = "Harry Potter and the Philosopher's Stone",
                    YearLauch = "2000",
                    Edition = 1,
                    PublishingCompany = "Rocco",
                    UrlWebImg = "https://m.media-amazon.com/images/I/61jgm6ooXzL.jpg",
                    Price = 30.99M,
                    AuthorId = 3
                },               
                new {
                    BookId = 4,
                    Name = "Por Lugares Incriveis",
                    YearLauch = "2015",
                    Edition = 5,
                    PublishingCompany = "Seguinte",
                    UrlWebImg = "https://m.media-amazon.com/images/I/510HCDDGb3L._SY344_BO1,204,203,200_QL70_ML2_.jpg",
                    Price = 60M,
                    AuthorId = 4         
                },
                new {
                    BookId = 5,
                    Name = "it a coisa",
                    YearLauch = "2014",
                    Edition = 1,
                    PublishingCompany = "Suma",
                    UrlWebImg = "https://m.media-amazon.com/images/I/51z0s3GcvwL._SY344_BO1,204,203,200_QL70_ML2_.jpg",
                    Price = 45M,
                    AuthorId = 5
                },
                new {
                    BookId = 6,
                    Name = "É assim que acaba",
                    YearLauch = "2018",
                    Edition = 1,
                    PublishingCompany = "Galera",
                    UrlWebImg = "https://m.media-amazon.com/images/I/51i7kH+rh9L._SY344_BO1,204,203,200_.jpg",
                    Price = 30M,
                    AuthorId = 6
                },
                new {
                    BookId = 7,
                    Name = "A garota do Lago",
                    YearLauch = "2022",
                    Edition = 1,
                    PublishingCompany = "Scholastic Press",
                    UrlWebImg = "https://m.media-amazon.com/images/I/516VOgxwg2L._SY344_BO1,204,203,200_QL70_ML2_.jpg",
                    Price = 80M,
                    AuthorId = 7
                }                
           );
        }
    }
}