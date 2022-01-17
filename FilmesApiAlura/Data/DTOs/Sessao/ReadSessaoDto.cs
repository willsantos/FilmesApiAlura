using FilmesApiAlura.Models;
using System;


namespace FilmesApiAlura.Data.DTOs
{
    public class ReadSessaoDto
    {
        public int Id { get; set; }
        public Filme Filme { get; set; }
        public Models.Cinema Cinema { get; set; }

        
        public DateTime HorarioDeEncerramento { get; set; }
        public DateTime HorarioDeInicio { get; set; }

    }
}
