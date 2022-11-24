using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.DAL.Entities;

namespace WebLibraryApp.DAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Find(Expression<Func<T, Boolean>> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
