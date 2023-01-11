using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.BLL.DTO;
using WebLibraryAppMVC.BLL.Interfaces;
using WebLibraryAppMVC.BLL.Infrastructure;
using WebLibraryAppMVC.DAL.Entities;
using WebLibraryAppMVC.DAL.Repoositories;


namespace WebLibraryAppMVC.BLL.Services
{
    public class RegistrationService : IRegistrationService
    {
        private EFUnitOfWork UnitOfWork;

        public RegistrationService(EFUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }

        public void DeleteUser(int id)
        {
            if (UnitOfWork.User.Get(id) == null || UnitOfWork.UserCard.Get(id) == null)
                throw new ValidationException("User doesn`t exist", "");
            UnitOfWork.UserCard.Delete(id);
            UnitOfWork.User.Delete(id);
            UnitOfWork.Save();
        }

        public void RegisterUser(UserDTO user)
        {
            if (user == null)
                throw new ValidationException("No info about user", "");
            var testUser = UnitOfWork.User.Find(u => u.Login.Equals(user.Login));
            if (testUser.Count() > 0)
                throw new ValidationException("Login is taken", "");
            var NewUser = new User
            {
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                Login = user.Login,
                Password = user.Password
            };
            var NewUserCard = new UserCard
            {
                DateOfMaking = DateTime.Now,
                Books = new List<Book>(),
                User = NewUser
            };
            UnitOfWork.UserCard.Create(NewUserCard);
            UnitOfWork.User.Create(NewUser);
            UnitOfWork.Save();
        }
    }
}