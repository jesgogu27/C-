using BolgCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {

        IEnumerable<SelectListItem> GetListaCategorias(); //Permite crear un dropmenu u obtener dinamicamente la lista categorias

        void Update(Categoria categoria);
    }
}
