using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.DAL.Entities;

namespace WebLibraryAppMVC.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Author> Author { get; }
        IRepository<BookTopic> BookTopic { get; }
        IRepository<Book> Book { get; }
        IRepository<User> User { get; }
        IRepository<UserCard> UserCard { get; }
        void Save();
        void Dispose();
    }
}