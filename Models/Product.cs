/*using System.ComponentModel.DataAnnotations;

namespace ProjetoEscola_API.Models
{
    public class Product
    {
        [Key]    
        public int id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 caracteres")]
       
        public string Description { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(5, ErrorMessage = "Este campo deve ter no máximo 5 caracteres")]

        public int Ra { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(30, ErrorMessage = "Este campo deve ter no máximo 5 caracteres")]

        public int Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(2, ErrorMessage = "Este campo deve ter no máximo 5 caracteres")]

        public int codCurso { get; set; }

        public Category Category { get; set;}
    }
}*/