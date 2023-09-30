using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ControleVendas.Models
{
    public class CategoriaDoProduto
    {
        [Key]
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Produto")]
        [Required(ErrorMessage = "Produto deve ser informado")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [DisplayName("Categoria")]
        [Required(ErrorMessage = "Categoria deve ser informada")]
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}