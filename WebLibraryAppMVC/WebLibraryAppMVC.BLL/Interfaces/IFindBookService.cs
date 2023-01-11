using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.BLL.DTO;

namespace WebLibraryAppMVC.BLL.Interfaces
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