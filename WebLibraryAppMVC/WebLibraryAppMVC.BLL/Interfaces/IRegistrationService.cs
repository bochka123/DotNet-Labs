using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.BLL.DTO;

namespace WebLibraryAppMVC.BLL.Interfaces
{
    public interface IRegistrationService
    {
        void RegisterUser(UserDTO user);
        void DeleteUser(int id);
    }
}