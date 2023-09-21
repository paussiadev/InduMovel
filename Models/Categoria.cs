using System.ComponentModel.DataAnnotations;

namespace InduMovel.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId {get; set;}
        [Required(ErrorMessage= "Informe o nome da categoria")]
        [Display(Name ="Nome Categoria")]
        [MinLength(5, ErrorMessage= "Categoria deve ter no mínimo {1} caracteres")]
        [MaxLength(20, ErrorMessage ="Categoria deve ter no maximo {1} caracteres")]
        public string Nome {get; set;}
        public List<Movel> Moveis {get; set;}
    }
}