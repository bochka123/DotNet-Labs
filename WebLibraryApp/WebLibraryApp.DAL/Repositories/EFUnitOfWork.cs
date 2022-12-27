using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.DAL.EF;
using WebLibraryApp.DAL.Entities;
using WebLibraryApp.DAL.Interfaces;

namespace WebLibraryApp.DAL.Repoositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private DataContext db;
        private AuthorRepository authorRepository;
        private BookRepository bookRepository;
        private BookTopicRepository bookTopicRepository;
        private UserRepository userRepository;
        private UserCardRepository userCardRepository;
        public EFUnitOfWork()
        {
            db = new DataContext();
        }
        public IRepository<Author> Author
        {
            get
            {
                if (authorRepository == null)
                {
                    authorRepository = new AuthorRepository(db);
                }
                return authorRepository;
            }
        }

        public IRepository<Book> Book
        {
            get
            {
                if (bookRepository == null)
                {
                    bookRepository = new BookRepository(db);
                }
                return bookRepository;
            }
        }
        public IDictionaryRepository<BookTopic> BookTopic
        {
            get
            {
                if (bookTopicRepository == null)
                {
                    bookTopicRepository = new BookTopicRepository(db);
                }
                return bookTopicRepository;
            }
        }
        public IRepository<User> User
        {
            get
            {
                if (userRepository == null)
                {
                    userRepository = new UserRepository(db);
                }
                return userRepository;
            }
        }
        public IRepository<UserCard> UserCard
        {
            get
            {
                if (userCardRepository == null)
                {
                    userCardRepository = new UserCardRepository(db);
                }
                return userCardRepository;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(true);
        }
    }
}
