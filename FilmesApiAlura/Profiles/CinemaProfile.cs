using AutoMapper;
using FilmesApiAlura.Data.DTOs.Cinema;
using FilmesApiAlura.Models;

namespace FilmesApiAlura.Profiles
{
    public class CinemaProfile : Profile
    {
        public CinemaProfile()
        {
            CreateMap<CreateCinemaDto, Cinema>();
            CreateMap<Cinema,ReadCinemaDto>();
            CreateMap<UpdateCinemaDto,Cinema>();
        }
    }
}
