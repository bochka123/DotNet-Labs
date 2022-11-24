using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WebLibraryApp.DAL.Entities;
using System.Data.Entity.Infrastructure;

namespace WebLibraryApp.DAL.EF
{
    public class DataContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookTopic> BookTopics { get; set; }
        public DbSet<User> Users { get; set; }
        static DataContext()
        {
            Database.SetInitializer<DataContext>(new StoreDbInitializer());
        }
        public DataContext(string connectionString) : base(connectionString)
        {

        }
    }
}
