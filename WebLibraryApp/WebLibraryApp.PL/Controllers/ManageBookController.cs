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

namespace WebLibraryApp.PL.Controllers
{
    public class ManageBookController : Controller
    {
        private IManageBookService service;
        public ManageBookController(IManageBookService service)
        {
            this.service = service;
        }
        public string TakeBook(int bookId, int userCardId)
        {
            try
            {
                service.TakeBook(bookId, userCardId);
                return "You took a book";
            }
            catch (ValidationException ex)
            {
                return ex.Message;
            }
        }
        public string GiveBook(int bookId, int userCardId)
        {
            try
            {
                service.GiveBook(bookId, userCardId);
                return "You gave a book";
            }
            catch(ValidationException ex)
            {
                return ex.Message;
            }
        }
        public string AddBook(string name, string numberOfExamples, string authors, string topics)
        {
            try
            {
                service.AddBook(name, numberOfExamples, authors, topics);
                return "You added a book";
            }
            catch (ValidationException ex)
            {
                return ex.Message;
            }
        }
    }
}
