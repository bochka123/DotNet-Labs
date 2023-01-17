using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLibraryAppMVC.PL.Models
{
    public class BookViewModel
    {
        public string Name { get; set; }
        public string Authors { get; set; }
        public string BookTopics { get; set; }
        public string NumberOfAvailable { get; set; }
    }
}