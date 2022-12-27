using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebLibraryApp.BLL.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int NumberOfAvailable { get; set; }
        public virtual ICollection<AuthorDTO> Authors { get; set; }
        public virtual ICollection<BookTopicDTO> BookTopics { get; set; }
    }
}
