using ApiProdutos.Data.Contexts;
using ApiProdutos.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiProdutos.Data.Repositories
{
    public class ProdutoRepository
    {
        public void Add(Produto produto)
        {
            using (var dataContext = new dataContext())
            {
                dataContext.Add(produto);
                dataContext.SaveChanges();

            }
        }

        public void Update(Produto produto)
        {
            using (var dataContext = new dataContext())
            {
                dataContext.Entry(produto).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }

        public void Delete(Produto produto)
        {
            using (var dataContext = new dataContext())
            {
                dataContext.Remove(produto);
                dataContext.SaveChanges();
            }
        }
            
        public List<Produto> GetAllByCategoria(Guid idCategoria)
        {
            using (var dataContext = new dataContext())
            {
                return dataContext.Produto
                    .Include(p => p.Categoria)
                    .Where(p => p.IdCategoria == idCategoria)
                    .OrderBy(p => p.Nome)
                    .ToList();
                        
            }
        }

        public Produto? GetById(Guid? idProduto)
        {
            using (var dataContext = new dataContext())
            {
                return dataContext.Produto
                    .Include(p => p.Categoria)
                    .FirstOrDefault(p =>p.IdProduto == idProduto);
            }
        }

        }
    }


