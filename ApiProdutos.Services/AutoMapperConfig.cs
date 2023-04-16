using ApiProdutos.Data.Entities;
using ApiProdutos.Services.Models;
using AutoMapper;

namespace ApiProdutos.Services
{
    public class AutoMapperConfig : Profile
    {
        private object produto;

        public AutoMapperConfig()
        {
            CreateMap<CategoriasPostModel, Categoria>()
                .AfterMap((model, entity) =>
                {
                    entity.IdCategoria = Guid.NewGuid();
                    entity.DataHoraCriacao = DateTime.Now;
                    entity.DataHoraUltimaAlteracao = DateTime.Now;
                });

            CreateMap<Categoria, CategoriasPostModel>();

            CreateMap<ProdutosPostModel, Produto>()
                .AfterMap((model, entity) =>
             {
                 entity.IdProduto = Guid.NewGuid();
                 entity.DataHoraCriacao = DateTime.Now;
                 entity.DataHoraUltimaAlteracao = DateTime.Now;

             });       

                
        }
    }
}
