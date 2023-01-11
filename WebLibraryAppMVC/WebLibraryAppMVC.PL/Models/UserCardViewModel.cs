using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLibraryAppMVC.PL.Models
{
    public class UserCardViewModel
    {
        public int Id { get; set; }
        public DateTime DateOfMaking { get; set; }
        public virtual IEnumerable<BookViewModel> Books { get; set; }
        public int UserId { get; set; }
    }
}