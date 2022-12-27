using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.DTO;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.BLL.Infrastructure;
using WebLibraryApp.DAL.Repoositories;
using WebLibraryApp.DAL.Entities;
using WebLibraryApp.DAL.Interfaces;
using AutoMapper;

namespace WebLibraryApp.BLL.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private EFUnitOfWork UnitOfWork;

        public AuthorizationService(EFUnitOfWork UnitOfWork)
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
            var mapper = new MapperConfiguration(config => config.CreateMap<UserCard, UserCardDTO>()).CreateMapper();
            if (id < 0) 
                throw new ValidationException("Id cannot be less than zero", "");
            var userCard = UnitOfWork.UserCard.Get(id);
            if (userCard == null) 
                throw new ValidationException("UserCard not found", "");
            return new UserCardDTO
            {
                Id = userCard.Id,
                DateOfMaking = userCard.DateOfMaking,
                Books = (ICollection<BookDTO>) userCard.Books,
                User = mapper.Map<User, UserDTO>(UnitOfWork.User.Get(userCard.Id))
            };
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
                throw new ValidationException("Password is wrong", "");
            }
        }
    }
}
