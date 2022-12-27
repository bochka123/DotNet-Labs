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
        public DbSet<UserCard> UserCards { get; set; }
        //static DataContext()
        //{
        //    Database.SetInitializer<DataContext>(new StoreDbInitializer());
        //}
        public DataContext() : base("Library")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>()
                .Property(a => a.Name)
                .HasColumnName("AuthorName");
            modelBuilder.Entity<Book>()
                .Property(b => b.Name)
                .HasColumnName("BookName");
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Login)
                .IsUnique();
            modelBuilder.Entity<User>()
                .Property(u => u.Login)
                .IsRequired()
                .HasColumnType("VARCHAR")
                .HasMaxLength(20);
            modelBuilder.Entity<User>()
                .Property(u => u.Login)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.FirstName)
                .IsRequired();
            modelBuilder.Entity<User>()
                .Property(u => u.Password)
                .IsRequired();
            modelBuilder.Entity<UserCard>()
                .Property(uc => uc.DateOfMaking)
                .HasColumnType("datetime2");
            modelBuilder.Entity<Author>()
                .HasMany<Book>(a => a.Books)
                .WithMany(b => b.Authors)
                .Map(ba =>
                {
                    ba.MapLeftKey("AuthorRefId");
                    ba.MapRightKey("BookRefId");
                    ba.ToTable("BookAuthor");
                });
            modelBuilder.Entity<BookTopic>()
                .HasMany<Book>(a => a.Books)
                .WithMany(b => b.BookTopics)
                .Map(ba =>
                {
                    ba.MapLeftKey("BookTopicRefId");
                    ba.MapRightKey("BookRefId");
                    ba.ToTable("BookBookTopic");
                });
            modelBuilder.Entity<User>()
                .HasOptional(uc => uc.Card)
                .WithRequired(u => u.User);
            base.OnModelCreating(modelBuilder);
        }
    }
}
