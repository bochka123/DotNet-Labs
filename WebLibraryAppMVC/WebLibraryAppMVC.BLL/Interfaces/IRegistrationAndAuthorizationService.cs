using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.BLL.DTO;

namespace WebLibraryAppMVC.BLL.Interfaces
{
    public interface IRegistrationAndAuthorizationService
    {
        UserDTO FindUser(int id);
        UserCardDTO FindUserCard(int id);
        UserDTO FindUserByLogin(string login);
        UserCardDTO FindUserCardByLogin(string login);
        IEnumerable<UserDTO> GetAllUsers();
        IEnumerable<UserCardDTO> GetAllUserCards();
        UserDTO Login(string login, string password);
        void RegisterUser(UserDTO user);
        void DeleteUser(int id);
    }
}