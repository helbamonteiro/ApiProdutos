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
    public class CategoriaRepository
    {
        public void Add(Categoria categoria)
        {
            using (var dataContext = new dataContext())
            {
                dataContext.Add(categoria);
                dataContext.SaveChanges();

            }
        }

        public void Update(Categoria categoria)
        {
            using (var dataContext = new dataContext())
            {
                dataContext.Entry(categoria).State = EntityState.Modified;
                dataContext.SaveChanges();
            }
        }

        public void Delete(Categoria categoria)
        {
            using (var dataContext = new dataContext())
            {
                dataContext.Remove(categoria);
                dataContext.SaveChanges();
            }
        }

        public List<Categoria> GetAll()
        {
            using (var dataContext = new dataContext())
            {
                return dataContext.Categoria
                    .OrderBy(c => c.Nome)
                    .ToList();
            }

        }

        public Categoria? GetById(Guid id)
        {
            using (var dataContext = new dataContext())
            {
                return dataContext.Categoria
                    .FirstOrDefault(c => c.IdCategoria == id);
            }
        }
    }
}
