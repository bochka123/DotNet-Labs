using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.DTO;
using WebLibraryApp.PL.Models;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.BLL.Infrastructure;
using System.Web.Mvc;

namespace WebLibraryApp.PL.Controllers
{
    public class AuthorizationController : Controller
    {
        private IAuthorizationService service;
        public AuthorizationController(IAuthorizationService service)
        {
            this.service = service;
        }
        public string Login(string login, string password)
        {
            
            try
            {
                service.Login(login, password);
            }
            catch(ValidationException ex)
            {
                return ex.Message;
            }
            return $"User {login} successfuly logged in";
        }
        public UserViewModel FindUserByLogin(string login)
        {
            UserDTO user = service.FindUserByLogin(login);
            return new UserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                Login = user.Login,
                Password = user.Password,
            };
        }
        public UserCardViewModel FindUserCardByLogin(string login)
        {
            UserCardDTO userCard = service.FindUserCardByLogin(login);
            return new UserCardViewModel
            {
                Id = userCard.Id,
                DateOfMaking = userCard.DateOfMaking,
                Books = userCard.Books.Select(b => new BookViewModel
                {
                    Id = b.Id,
                    Name = b.Name
                })
            };
        }
    }
}
