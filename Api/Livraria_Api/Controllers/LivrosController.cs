using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Livraria_Api.Entities;
using Livraria_Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Livraria_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LivrosController : ControllerBase
    {
        private readonly ILivroService _livroService;

        public LivrosController(ILivroService livroService)
        {
            _livroService = livroService;
        }

        [HttpGet("Todos_Livros")]
        public async Task<ActionResult<IAsyncEnumerable<Livro>>> GetTodosLivros()
        {
            var livros = await _livroService.Get_Livros();
            return Ok(livros);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Livro>> GetLivroPorId(int id)
        {
            var livro = await _livroService.Get_LivroPorId(id);

            return livro is null ? NotFound() : Ok(livro);
        }

        [HttpGet("Livro_Por_Nome")]
        public async Task<ActionResult<IAsyncEnumerable<Livro>>> GetLivroPorNome([FromQuery] string nome)
        {
            var livros = await _livroService.Get_LivroPorNome(nome);
            return livros.Count() == 0 ? NotFound() : Ok(livros);
        }

        [HttpPost]
        public async Task<ActionResult<Livro>> PostLivro(Livro livro)
        {
            await _livroService.Post_CriarLivro(livro);

            return CreatedAtAction(nameof(GetLivroPorId), new { id = livro.LivroId }, livro);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Livro>> DeleteLivro(int id)
        {
            var livro = await _livroService.Get_LivroPorId(id);

            if (livro is null)
                return NotFound();

            await _livroService.Delete_Livro(livro);

            return NoContent();
        }

    }
}