using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryApp.DAL;
using WebLibraryApp.DAL.EF;
using WebLibraryApp.DAL.Entities;
using WebLibraryApp.DAL.Repoositories;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EFUnitOfWork unitOfWork = new EFUnitOfWork();
            using (DataContext db = new DataContext())
            {

                // получаем объекты из бд и выводим на консоль
                var users = unitOfWork.User.GetAll();
                Console.WriteLine("Список объектов:");
                foreach (User u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Id, u.FirstName, u.SecondName);
                }
            }
            //Console.Read();
        }
    }
}
