using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLibraryAppMVC.PL.Models;
using WebLibraryAppMVC.BLL.Infrastructure;
using WebLibraryAppMVC.BLL.Interfaces;
using WebLibraryAppMVC.BLL.DTO;

namespace WebLibraryAppMVC.PL.Controllers
{
    //[Authorize]
    public class MainController : Controller
    {
        private IManageBookService manageBookService;
        private IFindBookService findBookService;
        private IRegistrationAndAuthorizationService registrationAndAuthorizationService;
        private string result;
        private string login;
        private List<BookDTO> books;
        public MainController(IManageBookService manageBookService,
            IFindBookService findBookService,
            IRegistrationAndAuthorizationService registrationAndAuthorizationService)
        {
            this.manageBookService = manageBookService;
            this.findBookService = findBookService;
            this.registrationAndAuthorizationService = registrationAndAuthorizationService;
        }
        public ActionResult Main(string login, List<BookDTO> books, string result = "")
        {
            //this.HttpContext.User.Identity.Name
            //UserManager
            this.books = books;
            List<BookDTO> allBooks;
            if (books == null)
            {
                allBooks = findBookService.FindAll().ToList();
            }
            else
            {
                allBooks = this.books;
            }
            this.login = login;
            this.result = result;
            ViewBag.Login = this.login;
            ViewBag.Result = result;
            ViewBag.AllBooks = allBooks;
            return View();
        }
        public ActionResult GiveBook(string login, string bookName)
        {
            int userId = registrationAndAuthorizationService.FindUserByLogin(login).Id;
            int bookId = findBookService.FindByName(bookName).First().Id;
            try
            {
                manageBookService.GiveBook(bookId, userId);
                result = "You succeessfuly gave a book";
            }
            catch (ValidationException ex)
            {
                result = ex.Message;
            }
            return this.RedirectToAction("Main", "Main", new { login, result });
        }
        public ActionResult TakeBook(string login, string bookName)
        {
            int userId = registrationAndAuthorizationService.FindUserByLogin(login).Id;
            int bookId = findBookService.FindByName(bookName).First().Id;
            try
            {
                manageBookService.TakeBook(bookId, userId);
                result = "You succeessfuly took a book";
            }
            catch (ValidationException ex)
            {
                result = ex.Message;
            }
            return this.RedirectToAction("Main", "Main", new { login, result });
        }
        public ActionResult Find(FindBookModel findBookModel, string login)
        {
            string find = findBookModel.FindString;
            string type = findBookModel.Type;
            books = new List<BookDTO>();
            if (type.Equals("Name"))
            {
                var booksByName = findBookService.FindByName(find);
                foreach (BookDTO book in booksByName)
                {
                    books.Add(book);
                }
            }
            else if (type.Equals("Author"))
            {
                var booksByAuthor = findBookService.FindByAuthorName(find);
                foreach (BookDTO book in booksByAuthor)
                {
                    books.Add(book);
                }
            }
            else if (type.Equals("BookTopic"))
            {
                var booksByTopic = findBookService.FindByBookTopicName(find);
                foreach (BookDTO book in booksByTopic)
                {
                    books.Add(book);
                }
            }
            ViewBag.AllBooks = books;
            return this.RedirectToAction("Main", "Main", new { login, books, result });

        }
    }
}