using AutoMapper;
using FilmesApiAlura.Data.DTOs;
using FilmesApiAlura.Models;

namespace FilmesApiAlura.Profiles
{
    public class SessaoProfile : Profile
    {
        public SessaoProfile()
        {
            CreateMap<CreateSessaoDto, Sessao>();
            CreateMap<Sessao, ReadSessaoDto>()
                .ForMember(dto => dto.HorarioDeInicio, opts => opts
                .MapFrom(dto => dto.HorarioDeEncerramento
                .AddMinutes(dto.Filme.Duracao * (-1))));

        }
    }
}
