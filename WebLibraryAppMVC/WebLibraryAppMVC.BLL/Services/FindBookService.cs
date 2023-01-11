using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.BLL.DTO;
using WebLibraryAppMVC.BLL.Interfaces;
using WebLibraryAppMVC.DAL.Repoositories;
using WebLibraryAppMVC.DAL.Entities;
using WebLibraryAppMVC.BLL.Infrastructure;

namespace WebLibraryAppMVC.BLL.Services
{
    public class FindBookService : IFindBookService
    {
        private EFUnitOfWork UnitOfWork;

        public FindBookService(EFUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
        public IEnumerable<BookDTO> FindAll()
        {
            var books = UnitOfWork.Book.GetAll();
            return books.Select(book => new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                NumberOfAvailable = book.NumberOfAvailable,
                Authors = book.Authors.Select(a => new AuthorDTO
                {
                    Id = a.Id,
                    Name = a.Name
                })
            });
        }

        public BookDTO FindBook(int id)
        {
            if (id < 0)
                throw new ValidationException("Id cannot be less than zero", "");
            Book book = UnitOfWork.Book.Get(id);
            if (book == null)
                throw new ValidationException("Book was not found", "");
            return new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                NumberOfAvailable = book.NumberOfAvailable,
                Authors = (IEnumerable<AuthorDTO>)book.Authors,
                BookTopics = (IEnumerable<BookTopicDTO>)book.BookTopics,
            };
        }

        public IEnumerable<BookDTO> FindByAuthorName(string name)
        {
            var books = UnitOfWork.Book.GetAll().ToList();
            List<BookDTO> result = new List<BookDTO>();
            foreach (var book in books)
            {
                foreach (var author in book.Authors)
                {
                    if (author.Name.Contains(name))
                    {
                        result.Add(new BookDTO
                        {
                            Id = book.Id,
                            Name = book.Name,
                            NumberOfAvailable = book.NumberOfAvailable,
                            Authors = book.Authors.Select(a => new AuthorDTO
                            {
                                Id = a.Id,
                                Name = a.Name
                            }),
                            BookTopics = book.BookTopics.Select(a => new BookTopicDTO
                            {
                                Id = a.Id,
                                Topic = a.Topic
                            })
                        });
                    }
                }
            }
            return result;
        }

        public IEnumerable<BookDTO> FindByBookTopicName(string name)
        {
            var books = UnitOfWork.Book.GetAll().ToList();
            List<BookDTO> result = new List<BookDTO>();
            foreach (var book in books)
            {
                foreach (var bookTopic in book.BookTopics)
                {
                    if (bookTopic.Topic.Contains(name))
                    {
                        result.Add(new BookDTO
                        {
                            Id = book.Id,
                            Name = book.Name,
                            NumberOfAvailable = book.NumberOfAvailable,
                            Authors = book.Authors.Select(a => new AuthorDTO
                            {
                                Id = a.Id,
                                Name = a.Name
                            }),
                            BookTopics = book.BookTopics.Select(a => new BookTopicDTO
                            {
                                Id = a.Id,
                                Topic = a.Topic
                            })
                        });
                    }
                }
            }
            return result;
        }

        public IEnumerable<BookDTO> FindByName(string name)
        {
            var books = UnitOfWork.Book.Find(e => e.Name.Contains(name));
            return books.Select(book => new BookDTO
            {
                Id = book.Id,
                Name = book.Name,
                NumberOfAvailable = book.NumberOfAvailable,
                Authors = book.Authors.Select(a => new AuthorDTO
                {
                    Id = a.Id,
                    Name = a.Name
                }),
                BookTopics = book.BookTopics.Select(a => new BookTopicDTO
                {
                    Id = a.Id,
                    Topic = a.Topic
                })
            });
        }
    }
}