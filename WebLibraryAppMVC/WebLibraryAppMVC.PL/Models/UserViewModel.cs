using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLibraryAppMVC.PL.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int CardId { get; set; }
    }
}