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
    class AuthorRepository : IRepository<Author>
    {
        private DataContext db;
        public AuthorRepository(DataContext context)
        {
            db = context;
        }
        public void Create(Author item)
        {
            db.Authors.Add(item);
        }

        public void Delete(int id)
        {
            Author author = db.Authors.Find(id);
            if (author != null)
            {
                db.Authors.Remove(author);
            }
        }

        public IEnumerable<Author> Find(Expression<Func<Author, bool>> predicate)
        {
            return db.Authors.Where(predicate).ToList();
        }

        public Author Get(int id)
        {
            return db.Authors.Find(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return db.Authors;
        }

        public void Update(Author item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
