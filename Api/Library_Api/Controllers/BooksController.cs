using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library_Api.Entities;
using Library_Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Library_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("All_Books")]
        public async Task<ActionResult<IAsyncEnumerable<Book>>> GetAllBooks()
        {
            var books = await _bookService.Get_Books();
            return Ok(books);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Book>> GetBookById(int id)
        {
            var book = await _bookService.Get_BookById(id);

            return book is null ? NotFound() : Ok(book);
        }

        [HttpGet("Book_By_Name")]
        public async Task<ActionResult<IAsyncEnumerable<Book>>> GetBookByName([FromQuery] string name)
        {
            var books = await _bookService.Get_BookByName(name);
            return books.Count() == 0 ? NotFound() : Ok(books);
        }

        [HttpPost]
        public async Task<ActionResult<Book>> PostBook(Book book)
        {
            await _bookService.Post_CreateBook(book);

            return CreatedAtAction(nameof(GetBookById), new { id = book.BookId }, book);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Book>> DeleteBook(int id)
        {
            var book = await _bookService.Get_BookById(id);

            if (book is null)
                return NotFound();

            await _bookService.Delete_Book(book);

            return NoContent();
        }

    }
}