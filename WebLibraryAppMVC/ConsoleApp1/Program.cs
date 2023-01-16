using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.DAL.Repositories;
using WebLibraryAppMVC.DAL.Interfaces;
using WebLibraryAppMVC.DAL.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork unitOfWork = new EFUnitOfWork();
            Book book = unitOfWork.Book.Get(8);
            book.BookTopics.Add(unitOfWork.BookTopic.Get(1));
            unitOfWork.Book.Update(book);
            unitOfWork.Save();
            
        }
    }
}
