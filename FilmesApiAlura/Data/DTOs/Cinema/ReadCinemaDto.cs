
using FilmesApiAlura.Models;
using System.ComponentModel.DataAnnotations;


namespace FilmesApiAlura
{
    public class ReadCinemaDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo nome eh obrigatorio")]
        public string Name { get; set; }
        public Endereco Endereco { get; set; }
        public Gerente Gerente { get; set; }

}
}
