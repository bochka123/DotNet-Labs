using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryAppMVC.BLL.DTO
{
    public class BookTopicDTO
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public virtual IEnumerable<BookDTO> Books { get; set; }
    }
}