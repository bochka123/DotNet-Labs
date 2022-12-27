using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.DTO;

namespace WebLibraryApp.BLL.Interfaces
{
    public interface IManageBookService
    {
        void TakeBook(int bookId, int userCardId);
        void GiveBook(int bookId, int userCardId);
    }
}
