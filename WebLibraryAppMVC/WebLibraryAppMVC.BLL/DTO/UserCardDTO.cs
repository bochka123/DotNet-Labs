using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryAppMVC.BLL.DTO
{
    public class UserCardDTO
    {
        public int Id { get; set; }
        public DateTime DateOfMaking { get; set; }
        public virtual IEnumerable<BookDTO> Books { get; set; }
        public UserDTO User { get; set; }
    }
}