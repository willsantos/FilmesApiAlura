using AutoMapper;
using FilmesApiAlura.Data;
using FilmesApiAlura.Data.DTOs;
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
        private IMapper _mapper;

        public FilmeController(FilmeContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto); 
            
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
                ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
                return Ok(filmeDto);
            }
            return NotFound();

        }


        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id,[FromBody] UpdateFilmeDto filmeDto)
        {
            Filme filme = buscaPorId(id);  
            if(filme == null)
            {
                return NotFound();
            }

            _mapper.Map(filmeDto, filme);

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
