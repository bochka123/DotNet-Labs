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
    public class AddBookController : Controller
    {
        IManageBookService service;
        private string login;
        public AddBookController(IManageBookService service)
        {
            this.service = service;
        }
        public ActionResult AddBook(string login)
        {
            this.login = login;
            ViewBag.Login = this.login;
            return View();
        }
        public ActionResult AddNewBook(BookViewModel bookViewModel, string login)
        {
            string result = "";
            if (bookViewModel.Authors == null ||
                bookViewModel.Name == null ||
                bookViewModel.BookTopics == null ||
                bookViewModel.NumberOfAvailable == null)
            {
                result = "Empty fields";
                ViewBag.Result = result;
                return this.RedirectToAction("AddBook", "AddBook", new { login });
            }
            string authors = bookViewModel.Authors;
            string name = bookViewModel.Name;
            string bookTopics = bookViewModel.BookTopics;
            string numberOfAvailable = bookViewModel.NumberOfAvailable;
            try
            {
                service.AddBook(name, numberOfAvailable, authors, bookTopics);
                result = "You added book successfuly";
            }catch(ValidationException ex)
            {
                result = ex.Message;
            }
            ViewBag.Result = result;
            return this.RedirectToAction("AddBook", "AddBook", new { login });
        }
    }
}