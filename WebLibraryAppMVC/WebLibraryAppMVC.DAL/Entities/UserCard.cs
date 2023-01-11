using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryAppMVC.DAL.Entities
{
    public class UserCard
    {
        public int Id { get; set; }
        public DateTime DateOfMaking { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public User User { get; set; }
    }
}