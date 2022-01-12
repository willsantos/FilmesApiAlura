﻿using AutoMapper;
using FilmesApiAlura.Data.DTOs;
using FilmesApiAlura.Models;

namespace FilmesApiAlura.Profiles
{
    public class FilmeProfile:Profile
    {
       public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<Filme, ReadFilmeDto>();
            CreateMap<UpdateFilmeDto, Filme>();

        }

    }

}
