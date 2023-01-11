using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLibraryAppMVC.PL.Models
{
    public class BookTopicViewModel
    {
        public int Id { get; set; }
        public string Topic { get; set; }
        public IEnumerable<BookViewModel> Books { get; set; }
    }
}