using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.DAL.EF;
using WebLibraryAppMVC.DAL.Entities;
using WebLibraryAppMVC.DAL.Interfaces;

namespace WebLibraryAppMVC.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private bool disposed = false;
        private DataContext db;
        private Repository<Author> authorRepository;
        private Repository<Book> bookRepository;
        private Repository<BookTopic> bookTopicRepository;
        private Repository<User> userRepository;
        private Repository<UserCard> userCardRepository;
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
                    authorRepository = new Repository<Author>(db);
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
                    bookRepository = new Repository<Book>(db);
                }
                return bookRepository;
            }
        }
        public IRepository<BookTopic> BookTopic
        {
            get
            {
                if (bookTopicRepository == null)
                {
                    bookTopicRepository = new Repository<BookTopic>(db);
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
                    userRepository = new Repository<User>(db);
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
                    userCardRepository = new Repository<UserCard>(db);
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