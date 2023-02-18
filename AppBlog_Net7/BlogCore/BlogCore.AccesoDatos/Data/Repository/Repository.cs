using BlogCore.AccesoDatos.Data.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.AccesoDatos.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {



        protected readonly DbContext _context;

        internal DbSet<T> dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            this.dbSet = context.Set<T>();
        }


        public void Add(T entity)
        {
         dbSet.Add(entity);
        }

        public T GET(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includePorperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            //Include Properties separados por coma

            if(includePorperties != null)
            {
                foreach (var includeProperty in includePorperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) //el RemoveEmpety permite remover los espacios en blanco
                {
                    query = query.Include(includeProperty);
                }
            }
            if(orderBy != null)
            {
                return orderBy(query).ToList(); 
            }

            return query.ToList();
        }

        public T GetFirstOrderDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if(includeProperties != null)
            {
                foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProperty);
                }
            }

            return query.FirstOrDefault(); //FirstOrDefault permite traer solo un registro
        }

        public void Remove(int id)
        {
            T entityToRemove = dbSet.Find(id);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
    }
}
