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
    class BookTopicRepository : IRepository<BookTopic>
    {
        private DataContext db;
        public BookTopicRepository(DataContext context)
        {
            db = context;
        }

        public void Create(BookTopic item)
        {
            db.BookTopics.Add(item);
        }

        public void Delete(int id)
        {
            BookTopic bookTopic = db.BookTopics.Find(id);
            if (bookTopic != null)
            {
                db.BookTopics.Remove(bookTopic);
            }
        }

        public IEnumerable<BookTopic> Find(Expression<Func<BookTopic, bool>> predicate)
        {
            return db.BookTopics.Where(predicate).ToList();
        }

        public BookTopic Get(int id)
        {
            return db.BookTopics.Find(id);
        }

        public IEnumerable<BookTopic> GetAll()
        {
            return db.BookTopics;
        }

        public void Update(BookTopic item)
        {
            db.Entry(item).State = EntityState.Modified;
        }
    }
}
