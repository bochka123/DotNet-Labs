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
        public int NumberOfExamples { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int BookTopicId { get; set; }
        public BookTopic Topic { get; set; }
    }
}
