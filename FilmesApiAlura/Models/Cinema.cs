﻿using System.ComponentModel.DataAnnotations;

namespace FilmesApiAlura.Models
{
    public class Cinema
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required(ErrorMessage ="O campo nome eh obrigatorio")]
        public string Name { get; set; }

    }
}
