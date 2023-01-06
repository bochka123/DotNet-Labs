using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.DTO;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.BLL.Infrastructure;
using WebLibraryApp.DAL.Repoositories;
using WebLibraryApp.DAL.Entities;

namespace WebLibraryApp.BLL.Services
{
    public class ManageBookService : IManageBookService
    {
        private EFUnitOfWork UnitOfWork;

        public ManageBookService(EFUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }

        public void AddBook(string name, string numberOfExamples, string author, string topic)
        {
            if (name.Equals(""))
                throw new ValidationException("You didn`t enter book name", "");
            int number;
            try
            {
                number = int.Parse(numberOfExamples);
            }
            catch (FormatException)
            {
                throw new ValidationException("Number of examples is not a number", "");
            }
            if(number <= 0)
                throw new ValidationException("Number of examples is less or equals zero", "");
            if (author.Equals(""))
                throw new ValidationException("You didn`t enter authors","");
            string[] authors = author.Split(',');
            if (topic.Equals(""))
                throw new ValidationException("You didn`t enter book topics", "");
            string[] topics = topic.Split(',');
            List<Book> allBooks = UnitOfWork.Book.GetAll().ToList();
            foreach (Book book in allBooks)
            {
                if (book.Name.Equals(name))
                {
                    if (authors.ToList().Count != book.Authors.ToList().Count)
                    {
                        throw new ValidationException("We have such book and it has another number of authors","");
                    }
                    if (topics.ToList().Count != book.Authors.ToList().Count)
                    {
                        throw new ValidationException("We have such book and it has another number of topics", "");
                    }
                    bool check = false;
                    foreach (Author aut in book.Authors)
                    {
                        int i = 0;
                        if (aut.Name == authors[i])
                        {
                            check = true;
                        }
                        i++;
                    }
                    if (!check)
                    {
                        throw new ValidationException("We have such book and it has another authors", "");
                    }
                    else
                    {
                        check = false;
                    }
                    foreach (BookTopic bt in book.BookTopics)
                    {
                        int i = 0;
                        if (bt.Topic == topics[i])
                        {
                            check = true;
                        }
                        i++;
                    }
                    if (!check)
                    {
                        throw new ValidationException("We have such book and it has another topics", "");
                    }
                    book.NumberOfAvailable += number;
                    UnitOfWork.Book.Update(book);
                    UnitOfWork.Save();
                    return;
                }
            }
            Book newBook = new Book
            {
                Name = name,
                NumberOfAvailable = number,
                Authors = new List<Author>(),
                BookTopics = new List<BookTopic>()
            };
            List<String> givenAuthorsList = authors.ToList();
            List<Author> allAuthors = UnitOfWork.Author.GetAll().ToList();
            foreach (String aut in givenAuthorsList.ToArray())
            {
                foreach(Author aut1 in allAuthors)
                {
                    if (aut.Equals(aut1.Name))
                    {
                        newBook.Authors.Add(aut1);
                        givenAuthorsList.Remove(aut);
                    }
                }   
            }
            
            foreach (String auth in givenAuthorsList) {
                newBook.Authors.Add(new Author
                {
                    Name = auth,
                });
            }
            List<String> givenBookTopicsList = topics.ToList();
            List<BookTopic> allBookTopics = UnitOfWork.BookTopic.GetAll().ToList();
            foreach (String bt in givenBookTopicsList.ToArray())
            {
                foreach (BookTopic bt1 in allBookTopics)
                {
                    if (bt.Equals(bt1.Topic))
                    {
                        newBook.BookTopics.Add(bt1);
                        givenBookTopicsList.Remove(bt);
                    }
                }
            }
            foreach (String bt in givenBookTopicsList)
            {
                newBook.BookTopics.Add(new BookTopic
                {
                    Topic = bt,
                });
            }
            UnitOfWork.Book.Create(newBook);
            UnitOfWork.Save();
        }

        public void GiveBook(int bookId, int userCardId)
        {
            if (bookId < 0)
                throw new ValidationException("Id cannot be less than zero", "");
            var book = UnitOfWork.Book.Get(bookId);
            if (book == null)
                throw new ValidationException("There is no such book", "");
            var userCard = UnitOfWork.UserCard.Get(userCardId);
            if (userCard == null)
                throw new ValidationException("There is no such user", "");
            var books = userCard.Books.ToList();
            bool check = false;
            foreach (var checkBook in books)
            {
                if (checkBook.Name.Equals(book.Name))
                {
                    check = true;
                    break;
                }
            }
            if (!check)
                throw new ValidationException("You don`t have this book", "");
            book.NumberOfAvailable++;
            userCard.Books.Remove(book);
            UnitOfWork.Book.Update(book);
            UnitOfWork.UserCard.Update(userCard);
            UnitOfWork.Save();
        }

        public void TakeBook(int bookId, int userCardId)
        {
            if (bookId < 0 || userCardId < 0)
                throw new ValidationException("Id cannot be less than zero", "");
            var book = UnitOfWork.Book.Get(bookId);
            if (book == null)
                throw new ValidationException("There is no such book", "");
            var userCard = UnitOfWork.UserCard.Get(userCardId);
            if (userCard == null)
                throw new ValidationException("There is no such user", "");
            if (book.NumberOfAvailable <= 0)
                throw new ValidationException("All examples of this book are taken", "");
            if (userCard.Books.Count > 10)
                throw new ValidationException("Book limit exceeded", "");
            List<Book> books = userCard.Books.ToList();
            foreach (Book checkBook in books)
            {
                if (checkBook.Id == book.Id)
                {
                    throw new ValidationException("You already have this book", "");
                }
            }
            book.NumberOfAvailable--;
            userCard.Books.Add(book);
            UnitOfWork.Book.Update(book);
            UnitOfWork.Save();
        }
    }
}
