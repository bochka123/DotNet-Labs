using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.BLL.DTO;
using WebLibraryAppMVC.BLL.Interfaces;
using WebLibraryAppMVC.BLL.Infrastructure;
using WebLibraryAppMVC.DAL.Repositories;
using WebLibraryAppMVC.DAL.Entities;
using WebLibraryAppMVC.DAL.Interfaces;
using AutoMapper;

namespace WebLibraryAppMVC.BLL.Services
{
    public class RegistrationAndAuthorizationService : IRegistrationAndAuthorizationService
    {
        private EFUnitOfWork UnitOfWork;

        public RegistrationAndAuthorizationService(EFUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
        public UserDTO FindUser(int id)
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<User, UserDTO>()).CreateMapper();
            if (id < 0)
                throw new ValidationException("Id cannot be less than zero", "");
            var user = UnitOfWork.User.Get(id);
            if (user == null)
                throw new ValidationException("User not found", "");
            return new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                SecondName = user.SecondName,
                Login = user.Login,
                Password = user.Password,
                Card = mapper.Map<UserCard, UserCardDTO>(UnitOfWork.UserCard.Get(user.Id))
            };
        }
        public UserCardDTO FindUserCard(int id)
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<UserCard, UserCardDTO>()
            .ForPath(a => a.User, opt => opt.MapFrom(aDTO => aDTO.User))
            .ForPath(a => a.Books, opt => opt.MapFrom(aDTO => aDTO.Books)))
                .CreateMapper();
            if (id < 0)
                throw new ValidationException("Id cannot be less than zero", "");
            var userCard = UnitOfWork.UserCard.Get(id);
            if (userCard == null)
                throw new ValidationException("UserCard not found", "");
            return new UserCardDTO
            {
                Id = userCard.Id,
                DateOfMaking = userCard.DateOfMaking,
                Books = userCard.Books.Select(a => new BookDTO
                {
                    Id = a.Id,
                    Name = a.Name,
                })
            };
        }
        public UserDTO FindUserByLogin(string login)
        {
            var user = UnitOfWork.User.Find(u => u.Login.Equals(login)).FirstOrDefault();
            if (user == null)
                throw new ValidationException("No user found!", "");
            var mapper = new Mapper(new MapperConfiguration(config => config.CreateMap<User, UserDTO>()));
            return mapper.Map<UserDTO>(user);
        }
        public UserCardDTO FindUserCardByLogin(string login)
        {
            var user = UnitOfWork.User.Find(u => u.Login.Equals(login)).FirstOrDefault();
            if (user == null)
                throw new ValidationException("No user card found!", "");
            int id = user.Id;
            return FindUserCard(id);
        }
        public IEnumerable<UserDTO> GetAllUsers()
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<User, UserDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<User>, List<UserDTO>>(UnitOfWork.User.GetAll());
        }
        public IEnumerable<UserCardDTO> GetAllUserCards()
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<UserCard, UserCardDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<UserCard>, List<UserCardDTO>>(UnitOfWork.UserCard.GetAll());
        }

        public UserDTO Login(string login, string password)
        {
            var mapper = new MapperConfiguration(config => config.CreateMap<User, UserDTO>()).CreateMapper();
            var users = mapper.Map<IEnumerable<User>, List<UserDTO>>(UnitOfWork.User.Find(ex => ex.Login.Equals(login)));

            if (users.Count == 0)
                throw new ValidationException("There is no such User", "");

            UserDTO userDTO = users[0];

            if (userDTO.Password.Equals(password))
            {
                return userDTO;
            }
            else
            {
                throw new ValidationException(password, "");
            }
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