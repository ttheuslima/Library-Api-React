using Livraria_Api.Entities;

namespace Livraria_Api.Interfaces
{
    public interface ILivroService
    {
        Task<IEnumerable<Livro>> Get_Livros();
        Task<Livro> Get_LivroPorId(int id);
        Task<IEnumerable<Livro>> Get_LivroPorNome(string nome);
        Task<IEnumerable<Livro>> Get_LivroPorAutor(string nome);
        Task<Livro> Post_CriarLivro();
        Task<Livro> Delete_Livro();
    }
}