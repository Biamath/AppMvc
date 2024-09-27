

using System.ComponentModel.DataAnnotations;

namespace AT_Net_Q7.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O título do livro é obrigatório")]
        [StringLength(50,ErrorMessage ="O titulo do livro deve ter no máximo 50 caracteres")]
        public string Titulo{ get; set; }

        [Required(ErrorMessage ="O nome do autor é obrigatório")]
        [StringLength(50,ErrorMessage = "O nome do autor deve ter no máximo 50 caracteres")]
        public string Autor { get; set; }

    }
}
