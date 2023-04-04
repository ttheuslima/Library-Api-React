using Library_Api.Entities;

namespace Library_Api.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> Get_Books();
        Task<Book> Get_BookById(int id);
        Task<IEnumerable<Book>> Get_BookByName(string name);
        Task Post_CreateBook(Book book);
        Task Delete_Book(Book book);
    }
}