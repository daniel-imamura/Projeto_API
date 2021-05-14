using System.ComponentModel.DataAnnotations;

namespace ProjetoEscola_API.Models
{
    public class Aluno
    {
        [Key]  
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(5, ErrorMessage = "Este campo deve ter no máximo 5 caracteres")]

        public string RA { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(30, ErrorMessage = "Este campo deve ter no máximo 30 caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, 99,ErrorMessage = "Este campo deve ter no máximo 5 caracteres")]

        public int codCurso { get; set; }

    }
}