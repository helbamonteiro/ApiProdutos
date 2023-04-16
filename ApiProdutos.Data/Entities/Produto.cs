using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProdutos.Data.Entities
{
    public class Produto
    {

        private Guid? _idProduto;
        private string? _nome;
        private string? _descricao;
        private decimal? _preco;
        private int? _quantidade;
        private Guid? _idCategoria;
        private DateTime? _dataHoraCriacao;
        private DateTime? _dataHoraUltimaAlteracao;
        private Categoria? _categoria;

        public Guid? IdProduto { get => _idProduto; set => _idProduto = value; }
        public String? Nome { get => _nome; set => _nome = value; }
        public String? Descricao { get => _descricao; set => _descricao = value; }
        public decimal? Preco { get => _preco; set => _preco = value; }
        public int? Quantidade { get => _quantidade; set => _quantidade = value; }
        public DateTime? DataHoraCriacao { get => _dataHoraCriacao; set => _dataHoraCriacao = value; }
        public DateTime? DataHoraUltimaAlteracao { get => _dataHoraUltimaAlteracao; set => _dataHoraUltimaAlteracao = value; }
        public Guid? IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public Categoria? Categoria { get => _categoria; set => _categoria = value; }
    }
}
