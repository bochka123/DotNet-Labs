using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryApp.DAL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Fake { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserCard Card { get; set; }
    }
}
