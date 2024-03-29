﻿using System;
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
            //Book b = unitOfWork.Book.Get(8);
            //Author a = unitOfWork.Author.Get(1);
            //b.Authors.Add(a);
            //unitOfWork.Book.Update(b);
            //unitOfWork.Save();
            UserCard card = unitOfWork.UserCard.Get(1);
            List<Book> books = card.Books.ToList();
            foreach (Book book in books)
            {
                Console.WriteLine(book.Name);
            }
            
        }
    }
}
