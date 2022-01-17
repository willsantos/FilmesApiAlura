using AutoMapper;
using FilmesApiAlura.Data;
using FilmesApiAlura.Data.DTOs;
using FilmesApiAlura.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FilmesApiAlura.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GerenteController: ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public GerenteController(AppDbContext context,IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpPost]
        public IActionResult AdicionaGerente(CreateGerenteDto dto)
        {
            Gerente gerente = _mapper.Map<Gerente>(dto);
            _context.Gerentes.Add(gerente);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaGerentesPorId), new { Id = gerente.Id }, gerente);

        }

        [HttpGet("{id}")]
        public IActionResult RecuperaGerentesPorId(int id)
        {
            Gerente gerente = BuscaPorId(id);
            if (gerente != null)
            {
                ReadGerenteDto gerenteDto = _mapper.Map<ReadGerenteDto>(gerente);
                return Ok(gerenteDto);
            }
            return NotFound();

        }

        [HttpDelete("{id}")]
        public IActionResult deletaFilme(int id)
        {
            Gerente gerente = BuscaPorId(id);
            if (gerente == null)
            {
                return NotFound();
            }

            _context.Remove(gerente);
            _context.SaveChanges();

            return NoContent();
        }
        private Gerente BuscaPorId(int id)
        {
            return _context.Gerentes.FirstOrDefault(gerente => gerente.Id == id);
        }





    }
}
