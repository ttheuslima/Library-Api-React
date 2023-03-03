using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria_Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Livraria_Api.Contexts
{
    public class LivrariaContext : DbContext
    {
        public LivrariaContext() { }
        public LivrariaContext(DbContextOptions<LivrariaContext> options) : base (options) { }

        public virtual DbSet<Autor> Autores { get; set; }
        public virtual DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>().HasData(
                new Autor
                {
                    AutorId = 1,
                    Nome = "JONATHAN SWIFT"
                },
                new Autor
                {
                    AutorId = 2,
                    Nome = "ROBERT LOUIS STEVERSON"
                },
                new Autor
                {
                    AutorId = 3,
                    Nome = "J. K. Rowling"
                }          
            );

            modelBuilder.Entity<Livro>().HasData(
                new {
                    LivroId = 1,
                    Nome = "Gulliver's Travels",
                    AnoLancamento = "1726",
                    Edicao = 1,
                    Editora = "OXFORD BOOKWORMS",
                    AutorId = 1         
                },
                new {
                    LivroId = 2,
                    Nome = "Dr Jekyll & Mr Hyde",
                    AnoLancamento = "1986",
                    Edicao = 3,
                    Editora = "RIchmond READERS",
                    AutorId = 2
                },
                new {
                    LivroId = 3,
                    Nome = "Harry Potter and the Philosopher's Stone",
                    AnoLancamento = "1997",
                    Edicao = 2,
                    Editora = "Editora Rocco",
                    AutorId = 3
                }                
           );
        }
    }
}