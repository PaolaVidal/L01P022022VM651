using System.ComponentModel.DataAnnotations;

namespace L01P022022VM651.Models
{
    public class alumnos
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Código")]
        [StringLength(10, ErrorMessage = "El código no debe superar los 10 caracteres.")]
        public string codigo { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        [StringLength(50, ErrorMessage = "El nombre no debe superar los 50 caracteres.")]
        public string nombre { get; set; }

        [Required]
        [Display(Name = "Apellidos")]
        [StringLength(50, ErrorMessage = "Los apellidos no deben superar los 50 caracteres.")]
        public string apellidos { get; set; }

        [Required]
        [Display(Name = "DUI")]
        public int dui { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public int estado { get; set; }
    }
}
