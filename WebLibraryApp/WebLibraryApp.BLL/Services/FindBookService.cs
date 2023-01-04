        using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.DTO;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.DAL.Repoositories;
using WebLibraryApp.DAL.Entities;
using WebLibraryApp.BLL.Infrastructure;

namespace WebLibraryApp.BLL.Services
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
                Authors = (ICollection<AuthorDTO>)book.Authors,
                BookTopics = (ICollection<BookTopicDTO>)book.BookTopics,
            };
        }

        public IEnumerable<BookDTO> FindByAuthorId(int id)
        {
            throw new NotImplementedException();
            //var mapper = new MapperConfiguration(config => config.CreateMap<Book, BookDTO>()).CreateMapper();
            //return mapper.Map<IEnumerable<Book>, List<BookDTO>>(UnitOfWork.Book.Find(e => e.Authors == Author));
        }

        public IEnumerable<BookDTO> FindByBookTopicId(int id)
        {
            throw new NotImplementedException();
            //var mapper = new MapperConfiguration(config => config.CreateMap<Book, BookDTO>()).CreateMapper();
            //Mapper.CreateMap<Book, BookDTO>()
            //.ForMember(dto => dto.providers, opt => opt.MapFrom(x => x.GoodsAndProviders.Select(y => y.Providers).ToList()));
        }

        public IEnumerable<BookDTO> FindByName(string name)
        {
            //var mapper = new MapperConfiguration(config => config.CreateMap<Book, BookDTO>()).CreateMapper();
            //return mapper.Map<IEnumerable<Book>, List<BookDTO>>(UnitOfWork.Book.Find(e => e.Name.Equals(name)));
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
