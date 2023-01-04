using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.PL.Models;
using WebLibraryApp.BLL.DTO;
using WebLibraryApp.BLL.Infrastructure;
using System.Web.Mvc;
using AutoMapper;

namespace WebLibraryApp.PL.Controllers
{
    public class FindBookController : Controller
    {
        private IFindBookService service;
        public FindBookController(IFindBookService service)
        {
            this.service = service;
        }
        public IEnumerable<BookViewModel> GetAllBooks()
        {
            var books = service.FindAll();
            return books.Select(book => new BookViewModel
            {
                Id = book.Id,
                Name = book.Name,
                NumberOfAvailable = book.NumberOfAvailable,
                Authors = book.Authors.Select(a => new AuthorViewModel
                {
                    Id = a.Id,
                    Name = a.Name
                })
            }).ToList();
        }
        public IEnumerable<BookViewModel> FindBookByName(string name)
        {
            var books = service.FindByName(name);
            //var mapper = new MapperConfiguration(config => config.CreateMap<BookDTO, BookViewModel>()).CreateMapper();
            //return mapper.Map<BookViewModel>(bookDTO);
            return books.Select(book => new BookViewModel
            {
                Id = book.Id,
                Name = book.Name,
                NumberOfAvailable = book.NumberOfAvailable,
                Authors = book.Authors.Select(a => new AuthorViewModel
                {
                    Id = a.Id,
                    Name = a.Name
                }),
                BookTopics = book.BookTopics.Select(a => new BookTopicViewModel
                {
                    Id = a.Id,
                    Topic = a.Topic
                })
            }).ToList();
        }
    }
}
