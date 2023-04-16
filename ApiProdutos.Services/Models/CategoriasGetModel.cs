namespace ApiProdutos.Services.Models
{
    public class CategoriasGetModel
    {
        public Guid? IdCategoria { get; set; }
        public String? Nome { get; set; }
        public String? Descricao { get; set; }
        public DateTime? DataHoraCriacao { get; set; }
        public DateTime? DataHoraUltimaAlteracao { get; set; }
    }
}
