using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.DAL.Entities;

namespace WebLibraryAppMVC.DAL.Interfaces
{
    public interface IRepository<T> where T : class //<TKey,TEntity> where TEntity : BaseEntity<TKey> // Tuple<TKey1,TKey2> as TKey
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        IEnumerable<T> Find(Expression<Func<T, Boolean>> predicate);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
    }
}
