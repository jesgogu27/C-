using BlogCore.AccesoDatos.Data.Repository.IRepository;
using BlogCore.Data;
using BolgCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public CategoriaRepository(ApplicationDbContext dbContext) : base (dbContext)
        {
            _dbContext = dbContext;
        }
    

        public IEnumerable<SelectListItem> GetListaCategorias()
        {
            return _dbContext.Categoria.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.IdCategoria.ToString() 
            });
        }

        public void Update(Categoria categoria)
        {
            var objDesdeDb = _dbContext.Categoria.FirstOrDefault(s => s.IdCategoria == categoria.IdCategoria);
            objDesdeDb.Nombre = categoria.Nombre;
            objDesdeDb.Orden = categoria.Orden;

            _dbContext.SaveChanges();   

        }
    }
}
