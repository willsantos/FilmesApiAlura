using AutoMapper;
using FilmesApiAlura.Data.DTOs.Gerente;
using FilmesApiAlura.Models;

namespace FilmesApiAlura.Profiles
{
    public class GerenteProfile: Profile
    {
        public GerenteProfile()
        {
            CreateMap<CreateGerenteDto, Gerente>();
            CreateMap<Gerente, ReadEnderecoDto>();
        }
    }
}
