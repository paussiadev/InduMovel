using System.ComponentModel.DataAnnotations;

namespace InduMovel.Models
{
    public class Movel
    {
        public int MovelId{get; set;}

        [Required(ErrorMessage= "Informe o nome do Móvel")]
        [Display(Name ="Nome Móvel")]
        [MinLength(4, ErrorMessage= "Móvel deve ter no mínimo {1} caracteres")]
        [MaxLength(20, ErrorMessage ="Móvel deve ter no maximo {1} caracteres")]
        public string Nome{get; set;}

        [Required(ErrorMessage= "Informe o nome da Descrição")]
        [Display(Name ="Nome Descrição")]
        [MinLength(20, ErrorMessage= "Descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(150, ErrorMessage ="Descrição deve ter no maximo {1} caracteres")]
        public string Descricao{get; set;}

        [Display(Name ="Cor")]
        [MaxLength(20, ErrorMessage ="Cor deve ter no maximo {1} caracteres")]
        public string Cor{get; set;}

        [Display(Name ="Imagem Grande")]
        public string ImagemUrl{get; set;}

        [Display(Name ="Imagem Pequena")]
        public string ImagemPequena{get; set;}

        [Display (Name ="Em produção")]
        public bool EmProducao{get; set;}

        [Display(Name= "Ativo")]
        public bool Ativo{get; set;}
        
        [Required (ErrorMessage = "Informe a categoria")]
        [Display(Name ="Categoria")]
        public bool CategoriaId{get; set;}
        
        public virtual Categoria Categoria{get; set;}
    }
}