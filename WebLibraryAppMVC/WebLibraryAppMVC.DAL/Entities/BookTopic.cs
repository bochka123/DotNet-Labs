using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryAppMVC.DAL.Entities
{
    public class BookTopic
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}