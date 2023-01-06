using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.DAL.Entities;

namespace WebLibraryApp.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Author> Author { get; }
        IRepository<Book> Book { get; }
        IRepository<User> User { get; }
        IRepository<UserCard> UserCard { get; }
        void Save();
        void Dispose();
    }
}
