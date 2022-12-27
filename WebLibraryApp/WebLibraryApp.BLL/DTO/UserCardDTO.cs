using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryApp.BLL.DTO
{
    public class UserCardDTO
    {
        public int Id { get; set; }
        public DateTime DateOfMaking { get; set; }
        public virtual ICollection<BookDTO> Books { get; set; }
        public UserDTO User { get; set; }
    }
}
