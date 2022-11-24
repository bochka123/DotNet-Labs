using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.DAL.Entities;
using System.Data.Entity;

namespace WebLibraryApp.DAL.EF
{
    public class StoreDbInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.BookTopics.Add(new BookTopic
            {
                Id = 1,
                Topic = "Adventures"
            });
            context.BookTopics.Add(new BookTopic
            {
                Id = 2,
                Topic = "Fairytale"
            });
            context.BookTopics.Add(new BookTopic
            {
                Id = 3,
                Topic = "Psychology"
            });
            context.Authors.Add(new Author
            {
                Id = 1,
                Name = "Valerian Pidmohylyny"
            });
            context.Authors.Add(new Author
            {
                Id = 2,
                Name = "Oksana Zabuzhko",
            });
            context.Authors.Add(new Author
            {
                Id = 3,
                Name = "Donna Tartt",
            });
            context.Authors.Add(new Author
            {
                Id = 4,
                Name = "Mark Twain",
            });
            context.Users.Add(new User
            {
                Id = 1,
                FirstName = "Oleksandr",
                SecondName = "Tkach",
                Login = "bochka123",
                Password = "0000"
            });
            context.Users.Add(new User
            {
                Id = 2,
                FirstName = "Nazariy",
                SecondName = "Von Gerste",
                Login = "fuckinburner",
                Password = "1111"
            });
            context.Books.Add(new Book
            {
                Id = 1,
                Name = "A little drama",
                NumberOfExamples = 3,
                AuthorId = 1,
                Author = context.Authors.Find(1),
                BookTopicId = 3,
                Topic = context.BookTopics.Find(3)
            });
            context.Books.Add(new Book
            {
                Id = 2,
                Name = "City",
                NumberOfExamples = 2,
                AuthorId = 1,
                Author = context.Authors.Find(1),
                BookTopicId = 3,
                Topic = context.BookTopics.Find(3)
            });
            context.Books.Add(new Book
            {
                Id = 3,
                Name = "Museum of Abandoned Secrets",
                NumberOfExamples = 2,
                AuthorId = 2,
                Author = context.Authors.Find(2),
                BookTopicId = 2,
                Topic = context.BookTopics.Find(2)
            });
            context.Books.Add(new Book
            {
                Id = 4,
                Name = "A tale about a viburnum pipe",
                NumberOfExamples = 3,
                AuthorId = 2,
                Author = context.Authors.Find(2),
                BookTopicId = 2,
                Topic = context.BookTopics.Find(2)
            });
            context.Books.Add(new Book
            {
                Id = 5,
                Name = "Goldfinch",
                NumberOfExamples = 2,
                AuthorId = 3,
                Author = context.Authors.Find(3),
                BookTopicId = 3,
                Topic = context.BookTopics.Find(3)
            });
            context.Books.Add(new Book
            {
                Id = 6,
                Name = "A secret story",
                NumberOfExamples = 3,
                AuthorId = 3,
                Author = context.Authors.Find(3),
                BookTopicId = 3,
                Topic = context.BookTopics.Find(3)
            });
            context.Books.Add(new Book
            {
                Id = 7,
                Name = "The Adventures of Tom Sawyer",
                NumberOfExamples = 2,
                AuthorId = 4,
                Author = context.Authors.Find(4),
                BookTopicId = 1,
                Topic = context.BookTopics.Find(1)
            });
            context.Books.Add(new Book
            {
                Id = 8,
                Name = "The prince and the pauper",
                NumberOfExamples = 3,
                AuthorId = 4,
                Author = context.Authors.Find(4),
                BookTopicId = 1,
                Topic = context.BookTopics.Find(1)
            });
            context.SaveChanges();
        }
    }
}
