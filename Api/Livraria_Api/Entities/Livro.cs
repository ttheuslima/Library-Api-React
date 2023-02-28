using System.ComponentModel.DataAnnotations;

namespace Livraria_Api.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
        [Required]
        public DateTime DataLancamento { get; set; }
        [Required]
        public int Edicao { get; set; }
        [Required]
        [StringLength(50)]
        public string Editora { get; set; }
        public Autor Autor { get; set; }
    }
}