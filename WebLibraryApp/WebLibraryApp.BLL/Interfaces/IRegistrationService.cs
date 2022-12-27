using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.DTO;

namespace WebLibraryApp.BLL.Interfaces
{
    public interface IRegistrationService
    {
        void RegisterUser(UserDTO user);
        void DeleteUser(int id);
    }
}
