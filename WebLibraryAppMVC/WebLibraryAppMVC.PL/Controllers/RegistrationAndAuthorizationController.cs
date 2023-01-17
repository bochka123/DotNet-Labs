﻿using System;
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
    public class RegistrationAndAuthorizationController : Controller
    {
        private IRegistrationAndAuthorizationService service;
        public RegistrationAndAuthorizationController(IRegistrationAndAuthorizationService service)
        {
            this.service = service;
        }
        public ActionResult RegistrationAndAuthorization(string login)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserViewModel userViewModel)
        {
            string result = string.Empty;

            if (ModelState.IsValid
                //userViewModel.FirstName == null ||
                //userViewModel.SecondName == null ||
                //userViewModel.Login == null ||
                //userViewModel.Password == null
                )
            {
                //Way one return view from with cirrent instance of model
                //Way two return ModelStateDetails - bad way
                //result = "Empty fields";
                ModelState.Keys.Contains(nameof(userViewModel.Login)).ToString();
                ViewBag.Result = result;
                return View("RegistrationAndAuthorization");
            }
            string firstName = userViewModel.FirstName;
            string secondName = userViewModel.SecondName;
            string login = userViewModel.Login;
            string password = userViewModel.Password;

            UserDTO user = new UserDTO
            {
                FirstName = firstName,
                SecondName = secondName,
                Login = login,
                Password = password
            };
            try
            {
                service.RegisterUser(user);
                result = "Registered successful!";
            }
            catch (ValidationException e)
            {
                result = e.Message;
            }
            ViewBag.Result = result;
            return View("RegistrationAndAuthorization");
        }
        public ActionResult Login(UserViewModel userViewModel)
        {
            string result = string.Empty;
            string login = "", password = "";
            if (userViewModel.Login == null ||
                userViewModel.Password == null)
            {
                result = "Empty fields";
                ViewBag.Result = result;
                return View("RegistrationAndAuthorization");
            }
            
            login = userViewModel.Login;
            password = userViewModel.Password;

            try
            {
                var user = service.Login(login, password);
                result = "Login successful!";
                return this.RedirectToAction("Main", "Main", new { login });
            }
            catch (ValidationException e)
            {
                result = e.Message;
            }
            ViewBag.Result = result;
            return View("RegistrationAndAuthorization");
        }
    }
}