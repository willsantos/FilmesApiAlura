﻿using System;

namespace FilmesApiAlura.Data.DTOs
{
    public class CreateSessaoDto
    {
        public int CinemaId { get; set; }
        public int FilmeId { get; set; }

        public DateTime HorarioDeEncerramento { get; set; }
    }
}
