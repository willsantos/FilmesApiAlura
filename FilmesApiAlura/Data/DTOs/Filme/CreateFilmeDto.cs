using System.ComponentModel.DataAnnotations;

namespace FilmesApiAlura.Data.DTOs
{
    public class CreateFilmeDto
    {
        [Required(ErrorMessage = "O Campo titulo é obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo diretor eh obrigatorio")]
        public string Diretor { get; set; }

        [StringLength(30, ErrorMessage = "O gênero não pode passar de 30 caracteres")]
        public string Genero { get; set; }

        [Range(10, 400, ErrorMessage = "A duracao deve ter no minimo 10 e no maximo 400 minutos")]
        public int Duracao { get; set; }
    }
}
