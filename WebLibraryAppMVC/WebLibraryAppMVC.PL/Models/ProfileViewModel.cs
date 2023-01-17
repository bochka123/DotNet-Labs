using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLibraryAppMVC.PL.Models
{
    public class ProfileViewModel
    {
        public UserViewModel userViewModel { get; set; }
        public UserCardViewModel userCardViewModel { get; set; }
    }
}