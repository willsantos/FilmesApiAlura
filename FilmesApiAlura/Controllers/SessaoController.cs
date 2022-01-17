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
    public class SessaoController: ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;

        public SessaoController(AppDbContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }
       
        [HttpPost]
        public IActionResult AdicionaSessao(CreateSessaoDto dto) {
            Sessao sessao = _mapper.Map<Sessao>(dto);
            _context.Sessoes.Add(sessao);
            _context.SaveChanges();

            return CreatedAtAction(nameof(RecuperaSessoesPorId), new { Id = sessao.Id }, sessao);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaSessoesPorId(int id)
        {
            Sessao sessao = _context.Sessoes.FirstOrDefault(sessao =>sessao.Id == id);
            if(sessao != null)
            {
                ReadSessaoDto sessaoDto = _mapper.Map<ReadSessaoDto>(sessao);
                return Ok(sessao);
            }
            return NotFound();
        }

    }
}
