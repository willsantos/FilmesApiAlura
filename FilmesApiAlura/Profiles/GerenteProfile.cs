using AutoMapper;
using FilmesApiAlura.Data.DTOs;
using FilmesApiAlura.Models;
using System.Linq;

namespace FilmesApiAlura.Profiles
{
    public class GerenteProfile: Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadGerenteDto>()
                .ForMember(gerente => gerente.Cinemas, opts => opts
                .MapFrom(gerente => gerente.Cinemas.Select(c => new { c.Id, c.Name, c.Endereco, c.EnderecoId }))
                );
        }
    }
}
