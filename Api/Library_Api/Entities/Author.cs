using System.ComponentModel.DataAnnotations;

namespace Library_Api.Entities
{
    public class Author
    {
        public int AuthorId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}