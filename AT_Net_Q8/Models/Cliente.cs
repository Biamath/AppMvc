
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AT_Net_Q8.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(50, ErrorMessage = "O nome deve ter no máximo 50 caracteres")]
        public string Nome{ get; set; }

        [Required(ErrorMessage = "O e-maill é obrigatório")]
        [StringLength(50, ErrorMessage = "O e-maill  deve ter no máximo 50 caracteres")]
  
        public string Email{ get; set; }

       
    }
}
