using System.ComponentModel.DataAnnotations;

namespace FilmesApiAlura.Data.DTOs.Cinema
{
    public class CreateCinemaDto
    {
        [Required(ErrorMessage="O campo nome eh obrigatorio")]
        public string Name { get; set; }
        public int EnderecoId { get; set; }
        public int GerenteId { get; set; }

    }
}
