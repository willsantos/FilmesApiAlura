
using FilmesApiAlura.Models;
using System.ComponentModel.DataAnnotations;

namespace FilmesApiAlura.Data.DTOs
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome eh obrigatorio")]
        public string Name { get; set; }

    }
}
