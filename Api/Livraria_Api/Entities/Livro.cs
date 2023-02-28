using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria_Api.Entities
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public int Edicao { get; set; }
        public string Editora { get; set; }
        public Autor Autor { get; set; }
    }
}