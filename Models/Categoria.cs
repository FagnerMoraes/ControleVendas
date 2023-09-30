using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class Categoria
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome")]
        [StringLength(80, ErrorMessage = "O nome deve conter no maximo 80 caracteres")]
        [MinLength(5, ErrorMessage = "O nome deve conter no minimo 5 caracteres")]
        [DisplayName("Nome da Categoria")]
        public string? Nome { get; set; }
    }
}