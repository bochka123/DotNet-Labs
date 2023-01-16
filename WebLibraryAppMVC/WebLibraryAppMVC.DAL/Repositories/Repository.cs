using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using WebLibraryAppMVC.DAL.EF;
using WebLibraryAppMVC.DAL.Entities;
using WebLibraryAppMVC.DAL.Interfaces;

namespace WebLibraryAppMVC.DAL.Repositories
{
    class Repository<T> : IRepository<T> where T : class
    {
        private DataContext db;
        private DbSet<T> dbSet;
        public Repository(DataContext context)
        {
            db = context;
            dbSet = db.Set<T>();
        }
        public void Create(T element)
        {
            dbSet.Add(element);
        }

        public void Delete(int id)
        {
            T element = dbSet.Find(id);
            if (element != null)
            {
                dbSet.Remove(element);
            }
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return dbSet.Where(predicate).ToList();
        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet;
        }

        public void Update(T item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}