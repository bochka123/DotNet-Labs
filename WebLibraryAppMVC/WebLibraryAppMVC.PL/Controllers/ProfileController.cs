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
    public class ProfileController : Controller
    {
        private IRegistrationAndAuthorizationService service;
        public ProfileController(IRegistrationAndAuthorizationService service)
        {
            this.service = service;
        }
        public new ActionResult Profile(string login)
        {
            var userModel = service.FindUserByLogin(login);
            var userCardModel = service.FindUserCardByLogin(login);
            ViewBag.Login = login;
            ViewBag.FirstName = userModel.FirstName;
            ViewBag.SecondName = userModel.SecondName;
            ViewBag.DateOfMaking = userCardModel.DateOfMaking;
            if (userCardModel.Books.Count() != 0) {
                var books = userCardModel.Books.ToList();
                int i = 1;
                foreach (var book in books)
                {
                    if (i < books.Count()) {
                        ViewBag.Books += $"{book.Name}, ";
                    }
                    else
                    {
                        ViewBag.Books += book.Name;
                    }
                    i++;
                }
            }
            else
            {
                ViewBag.Books = "You don`t have any books :(";
            }
            return View();
        }

        public ActionResult DeleteAccount(string login)
        {
            var userModel = service.FindUserByLogin(login);
            service.DeleteUser(userModel.Id);
            return this.RedirectToAction("RegistrationAndAuthorization", "RegistrationAndAuthorization");
        }
    }
}