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
    public class RegistrationController : Controller
    {
        private IRegistrationService service;
        public RegistrationController(IRegistrationService service)
        {
            this.service = service;
        }
        public string Register(UserViewModel user)
        {
            UserDTO userDTO = new UserDTO
            {
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                Login = user.Login,
                Password = user.Password,
            };

            try
            {
                service.RegisterUser(userDTO);
            }
            catch (ValidationException ex)
            {
                return ex.Message;
            }
            return $"User { user.Login } registered succesfully ";
        }

    }
}
