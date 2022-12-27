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
    class BookTopicRepository : IDictionaryRepository<BookTopic>
    {
        private DataContext db;
        public BookTopicRepository(DataContext context)
        {
            db = context;
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
    }
}
