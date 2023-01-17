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
            var topics = unitOfWork.Book.Get(1).BookTopics;
            foreach (var topic in topics)
            {
                Console.WriteLine(topic.Topic);
            }
            //UserCard userCard = unitOfWork.UserCard.Get(1);
            //userCard.Books.Add(unitOfWork.Book.Get(1));
            //unitOfWork.UserCard.Update(userCard);
            //unitOfWork.Save();
            
        }
    }
}
