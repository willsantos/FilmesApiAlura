using AutoMapper;
using FilmesApiAlura.Data;
using FilmesApiAlura.Data.DTOs;
using FilmesApiAlura.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Linq;

namespace FilmesApiAlura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CinemaController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public CinemaController(AppDbContext context, IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }



        [HttpGet]
        public IEnumerable RecuperaCinemas([FromQuery] string nomeDoFilme)
        {
            return _context.Cinemas;
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaCinemasPorId(int id) { 
            Cinema cinema = _context.Cinemas.FirstOrDefault(cinema=>cinema.Id ==id);
            if(cinema != null)
            {
                ReadCinemaDto cinemaDto = _mapper.Map<ReadCinemaDto>(cinema);
                return Ok(cinemaDto);
            }
           return NotFound();
        }

        [HttpPost]
        public IActionResult AdicionaCinema([FromBody] CreateCinemaDto cinemaDto)
        {
            Cinema cinema = _mapper.Map<Cinema>(cinemaDto);
            _context.Cinemas.Add(cinema);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaCinemasPorId), new { Id = cinema.Id }, cinema);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaCinema(int id,[FromBody] UpdateCinemaDto cinemaDto)
        {
            Cinema cinema = buscaCinemaPorId(id);
            if (cinema == null)
            {
                return NotFound();
            }
            _mapper.Map(cinemaDto, cinema);
            _context.SaveChanges();
            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult DeletaCinema(int id)
        {
            Cinema cinema = buscaCinemaPorId(id);
            if(cinema == null)
            {
                return NotFound();
            }
            _context.Remove(cinema);
            _context.SaveChanges();
            return NoContent();
        }

        private Cinema buscaCinemaPorId(int id)
        {
            return _context.Cinemas.FirstOrDefault(cinema => cinema.Id == id);
        }

    }

    
}
