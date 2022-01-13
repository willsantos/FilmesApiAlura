﻿using AutoMapper;
using FilmesApiAlura.Data.DTOs.Endereco;
using FilmesApiAlura.Models;

namespace FilmesApiAlura.Profiles
{
    public class EnderecoProfile: Profile
    {
        public EnderecoProfile()
        {
            CreateMap<CreateEnderecoDto, Endereco>();
            CreateMap<Endereco, ReadEnderecoDto>();
            CreateMap<UpdateEnderecoDto, Endereco>();
        }
    }
}
