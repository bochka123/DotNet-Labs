using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.DAL.Repoositories;
using WebLibraryAppMVC.DAL.Interfaces;
using WebLibraryAppMVC.DAL.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork unitOfWork = new EFUnitOfWork();
            UserCard card = unitOfWork.UserCard.Get(1);
            List<Book> books = card.Books.ToList();
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name);
            }
        }
    }
}
