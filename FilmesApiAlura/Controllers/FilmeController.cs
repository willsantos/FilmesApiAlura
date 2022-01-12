using FilmesApiAlura.Data;
using FilmesApiAlura.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesApiAlura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        private FilmeContext _context;


        public FilmeController(FilmeContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            _context.Filmes.Add(filme);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaFilmePorId), new { id = filme.Id }, filme);

        }

        [HttpGet]
        public IEnumerable<Filme> RecuperarFilmes()
        {
            return _context.Filmes;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmePorId(int id)
        {
            Filme filme = buscaPorId(id);
            if (filme != null)
            {
                return Ok(filme);
            }
            return NotFound();

        }


        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id,[FromBody] Filme filmeNovo)
        {
            Filme filme = buscaPorId(id);  
            if(filme == null)
            {
                return NotFound();
            }

            filme.Titulo = filmeNovo.Titulo;
            filme.Genero = filmeNovo.Genero;
            filme.Duracao = filmeNovo.Duracao;
            filme.Diretor = filmeNovo.Diretor;

            _context.SaveChanges();

            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult deletaFilme(int id)
        {
            Filme filme = buscaPorId(id);
            if(filme == null)
            {
                return NotFound();
            }

            _context.Remove(filme);
            _context.SaveChanges();

            return NoContent();
        }

        private Filme buscaPorId(int id)
        {
            return _context.Filmes.FirstOrDefault(filme => filme.Id == id);
        }
    }
}
