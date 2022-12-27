using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.BLL.DTO;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.BLL.Infrastructure;
using WebLibraryApp.DAL.Repoositories;

namespace WebLibraryApp.BLL.Services
{
    public class ManageBookService : IManageBookService
    {
        private EFUnitOfWork UnitOfWork;

        public ManageBookService(EFUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
        public void GiveBook(int bookId, int userCardId)
        {
            if (bookId < 0)
                throw new ValidationException("Id cannot be less than zero", "");
            var Book = UnitOfWork.Book.Get(bookId);
            if (Book == null)
                throw new ValidationException("There is no such book", "");
            var UserCard = UnitOfWork.UserCard.Get(userCardId);
            if (UserCard == null)
                throw new ValidationException("There is no such user", "");
            Book.NumberOfAvailable++;
            UserCard.Books.Remove(Book);
            UnitOfWork.Book.Update(Book);
            UnitOfWork.UserCard.Update(UserCard);
            UnitOfWork.Save();
        }

        public void TakeBook(int bookId, int userCardId)
        {
            if (bookId < 0 || userCardId < 0)
                throw new ValidationException("Id cannot be less than zero", "");
            var Book = UnitOfWork.Book.Get(bookId);
            if (Book == null)
                throw new ValidationException("There is no such book", "");
            var UserCard = UnitOfWork.UserCard.Get(userCardId);
            if (UserCard == null)
                throw new ValidationException("There is no such user", "");
            if (Book.NumberOfAvailable <= 0)
                throw new ValidationException("All examples of this book are taken", "");
            if (UserCard.Books.Count > 10)
                throw new ValidationException("Book limit exceeded", "");
            Book.NumberOfAvailable--;
            UserCard.Books.Add(Book);
            UnitOfWork.Book.Update(Book);
            UnitOfWork.UserCard.Update(UserCard);
            UnitOfWork.Save();
        }
    }
}
