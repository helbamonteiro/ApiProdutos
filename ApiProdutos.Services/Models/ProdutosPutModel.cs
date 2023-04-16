using System.ComponentModel.DataAnnotations;

namespace ApiProdutos.Services.Models
{
    public class ProdutosPutModel
    {
        [Required(ErrorMessage = "informe o Id do produto")]
        public Guid? Idproduto { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(100, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Nome do Produto é obrigatório")]
        public string? Nome { get; set; }

        [MinLength(6, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Nome do produto é obrigatório")]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Preço do produto é obrigatório")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "Quantidade do produto é obrigatório")]
        public int? Quantidade { get; set; }

        [Required(ErrorMessage = "Id da Categoria é obrigatório")]
        public Guid? IdCategoria { get; set; }

    }

    }

