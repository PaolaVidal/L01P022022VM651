using System.ComponentModel.DataAnnotations;

namespace L01P022022VM651.Models
{
    public class materias
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Materia")]
        [StringLength(100, ErrorMessage = "El nombre de la materia no debe superar los 100 caracteres.")]
        public string materia { get; set; }

        [Required]
        [Display(Name = "Unidades Valorativas")]
        public int unidades_valorativas { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public char estado { get; set; }
    }
}
