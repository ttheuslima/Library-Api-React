using System.ComponentModel.DataAnnotations;

namespace Livraria_Api.Entities
{
    public class Autor
    {
        public int AutorId { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }
    }
}