using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.DAL.Repoositories;
using WebLibraryApp.DAL.Interfaces;
using WebLibraryApp.DAL.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork unitOfWork = new EFUnitOfWork();
            Book b = unitOfWork.Book.Get(8);


            Console.WriteLine(b.BookTopics.First().Topic);
        }
    }
}
