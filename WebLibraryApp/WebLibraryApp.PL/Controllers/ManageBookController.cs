using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.PL.Models;
using WebLibraryApp.BLL.DTO;
using WebLibraryApp.BLL.Infrastructure;
using System.Web.Mvc;

namespace WebLibraryApp.PL.Controllers
{
    public class ManageBookController : Controller
    {
        private IManageBookService service;
        public ManageBookController(IManageBookService service)
        {
            this.service = service;
        }
        public void TakeBook(int bookId, int userCardId)
        {
            service.TakeBook(bookId, userCardId);
        }
    }
}
