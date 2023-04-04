using System.ComponentModel.DataAnnotations;

namespace Library_Api.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string YearLauch { get; set; }
        [Required]
        public int Edition { get; set; }
        [Required]
        [StringLength(50)]
        public string PublishingCompany { get; set; }
        [Required]
        [Url]
        public string UrlWebImg { get; set; }
        [Required]
        public decimal Price { get; set; }
        public Author Author { get; set; }
    }
}