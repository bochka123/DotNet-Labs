using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using WebLibraryApp.DAL.EF;
using WebLibraryApp.DAL.Entities;
using WebLibraryApp.DAL.Interfaces;

namespace WebLibraryApp.DAL.Repoositories
{
    class BookRepository : IRepository<Book>
    {
        private DataContext db;
        public BookRepository(DataContext context)
        {
            db = context;
        }
        public void Create(Book item)
        {
            db.Books.Add(item);
        }

        public void Delete(int id)
        {
            Book user = db.Books.Find(id);
            if (user != null)
            {
                db.Books.Remove(user);
            }
        }

        public IEnumerable<Book> Find(Expression<Func<Book, bool>> predicate)
        {
            return db.Books.Include(o => o.Author).Include(o => o.Topic).Where(predicate).ToList();
        }

        public Book Get(int id)
        {
            return db.Books.Find(id);
        }

        public IEnumerable<Book> GetAll()
        {
            return db.Books.Include(o => o.Author).Include(o => o.Topic);
        }

        public void Update(Book item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
