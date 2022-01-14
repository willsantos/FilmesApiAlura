using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace FilmesApiAlura.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo nome eh obrigatorio")]
        public string Name { get; set; }

        public virtual Endereco Endereco { get; set; }

        public int EnderecoId { get; set; }
        [JsonIgnore]
        public virtual Gerente Gerente { get; set; }
        [JsonIgnore]
        public int GerenteId { get; set; }
    }
}
