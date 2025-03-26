using System.ComponentModel.DataAnnotations;

namespace L01P022022VM651.Models
{
    public class facultades
    {
         [Key]
    public int id { get; set; }

    [Required]
    [Display(Name = "Facultad")]
    [StringLength(100, ErrorMessage = "El nombre de la facultad no debe superar los 100 caracteres.")]
    public string facultad { get; set; }
    }
}
