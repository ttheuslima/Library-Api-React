using Library_Api.Contexts;
using Library_Api.Entities;
using Library_Api.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Library_Api.Services
{
    public class BookService : IBookService
    {
        public BookService() { }

        private readonly LibraryContext _context;
        public BookService(LibraryContext context)
        {
            _context = context; 
        }

        public async Task<IEnumerable<Book>> Get_Books()
        {
            return await _context.Books.Include(x => x.Author)
                                        .ToListAsync();
        }

        public async Task<Book> Get_BookById(int id)
        {
            return await _context.Books.Include(i => i.Author)
                                        .FirstOrDefaultAsync(l => l.BookId == id);
        }

        public async Task<IEnumerable<Book>> Get_BookByName(string name)
        {
            IEnumerable<Book> books;
            if (!string.IsNullOrWhiteSpace(name))
            {
                books = await _context.Books.Where(n => n.Name.Contains(name))
                                              .Include(x => x.Author)
                                              .ToListAsync();
            }
            else
            {
                books = await Get_Books();
            }

            return books;
        }

        public async Task Post_CreateBook(Book book)
        {
            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();
        }

        public async Task Delete_Book(Book book)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
    }
}