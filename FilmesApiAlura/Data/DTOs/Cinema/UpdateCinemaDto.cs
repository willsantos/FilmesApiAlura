using System.ComponentModel.DataAnnotations;

namespace FilmesApiAlura.Data.DTOs.Cinema
{
    public class UpdateCinemaDto
    {
        [Required(ErrorMessage = "O campo nome eh obrigatorio")]
        public string Name { get; set; }

    }
}
