using Livraria_Api.Contexts;
using Livraria_Api.Entities;
using Livraria_Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Livraria_Api.Services
{
    public class LivroService : ILivroService
    {
        public LivroService() { }

        private readonly LivrariaContext _context;
        public LivroService(LivrariaContext context)
        {
            _context = context; 
        }

        public async Task<IEnumerable<Livro>> Get_Livros()
        {
            return await _context.Livros.Include(x => x.Autor)
                                        .ToListAsync();
        }

        public async Task<Livro> Get_LivroPorId(int id)
        {
            return await _context.Livros.Include(i => i.Autor)
                                        .FirstOrDefaultAsync(l => l.LivroId == id);
        }

        public async Task<IEnumerable<Livro>> Get_LivroPorNome(string nome)
        {
            IEnumerable<Livro> livros;
            if (!string.IsNullOrWhiteSpace(nome))
            {
                livros = await _context.Livros.Where(n => n.Nome.Contains(nome))
                                              .Include(x => x.Autor)
                                              .ToListAsync();
            }
            else
            {
                livros = await Get_Livros();
            }

            return livros;
        }

        public async Task Post_CriarLivro(Livro livro)
        {
            await _context.Livros.AddAsync(livro);
            await _context.SaveChangesAsync();
        }

        public async Task Delete_Livro(Livro livro)
        {
            _context.Livros.Remove(livro);
            await _context.SaveChangesAsync();
        }
    }
}