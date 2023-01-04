using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryApp.PL.Models
{
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<BookViewModel> Books{ get; set; }
    }
}
