using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.DTO;

namespace WebLibraryApp.BLL.Interfaces
{
    public interface IFindBookService
    {
        BookDTO FindBook(int id);
        IEnumerable<BookDTO> FindAll();
        IEnumerable<BookDTO> FindByName(string name);
        IEnumerable<BookDTO> FindByAuthorName(string name);
        IEnumerable<BookDTO> FindByBookTopicName(string name);
    }
}
