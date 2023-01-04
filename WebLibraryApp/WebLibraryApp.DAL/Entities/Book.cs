using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryApp.DAL.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfAvailable { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
        public virtual ICollection<BookTopic> BookTopics { get; set; }
        public virtual ICollection<UserCard> UserCards { get; set; }
    }
}
