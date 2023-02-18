using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        T GET(int id);
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
            string includePorperties =null
        ); //PERMITE OBTENER todos los datos

        T GetFirstOrderDefault(
            Expression<Func<T, bool>> filter =null,
            string includeProperties = null
        );


        void Add(T entity);

        void Remove(int id);

        void Remove(T entity);


    }
}
