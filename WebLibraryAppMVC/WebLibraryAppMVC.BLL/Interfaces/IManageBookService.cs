﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebLibraryAppMVC.BLL.DTO;

namespace WebLibraryAppMVC.BLL.Interfaces
{
    public interface IManageBookService
    {
        void TakeBook(int bookId, int userCardId);
        void GiveBook(int bookId, int userCardId);
        void AddBook(string name, string numberOfExamples, string authors, string topics);
    }
}