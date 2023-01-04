﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryApp.PL.Models
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfAvailable { get; set; }
        public virtual IEnumerable<AuthorViewModel> Authors { get; set; }
        public virtual IEnumerable<BookTopicViewModel> BookTopics { get; set; }
        public virtual IEnumerable<UserCardViewModel> UserCards { get; set; }
    }
}
