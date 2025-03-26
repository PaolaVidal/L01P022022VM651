using System.ComponentModel.DataAnnotations;

namespace L01P022022VM651.Models
{
    public class departamentos
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Departamento")]
        [StringLength(50, ErrorMessage = "El nombre del departamento no debe superar los 50 caracteres.")]
        public string departamento { get; set; }
    }
}
