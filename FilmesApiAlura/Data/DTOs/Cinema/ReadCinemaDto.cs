using System.ComponentModel.DataAnnotations;

namespace FilmesApiAlura.Data.DTOs.Cinema
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
