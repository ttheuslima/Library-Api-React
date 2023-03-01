using Livraria_Api.Entities;

namespace Livraria_Api.Interfaces
{
    public interface ILivroService
    {
        List<Livro> GetLivros();
        Livro Get_LivroPorId(int id);
        Livro Get_LivroPorNomr(string nome);
        Livro Get_LivroPorAutor(string nome);
        void Post_CriarLivro();
        void DeleteLivro();
    }
}