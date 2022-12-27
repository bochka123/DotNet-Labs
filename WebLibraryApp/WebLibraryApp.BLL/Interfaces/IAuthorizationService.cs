﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.DTO;

namespace WebLibraryApp.BLL.Interfaces
{
    public interface IAuthorizationService
    {
        UserDTO FindUser(int id);
        UserCardDTO FindUserCard(int id);
        IEnumerable<UserDTO> GetAllUsers();
        IEnumerable<UserCardDTO> GetAllUserCards();
        UserDTO Login(string login, string password);
    }
}