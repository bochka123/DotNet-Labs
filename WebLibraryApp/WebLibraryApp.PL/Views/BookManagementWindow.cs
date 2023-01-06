using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using WebLibraryApp.PL.Models;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.PL.Controllers;

namespace WebLibraryApp.PL.Views
{
    public partial class BookManagementWindow : Form
    {
        string login;
        private ManageBookController manageBookController;
        public BookManagementWindow(string login)
        {
            IKernel kernel = Program.Kernel;
            var manageBookService = kernel.Get<IManageBookService>();
            manageBookController = new ManageBookController(manageBookService);
            this.login = login;
            InitializeComponent();
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow window = new MainWindow(login);
            window.Show();
        }

        private void AddBook_Click(object sender, EventArgs e)
        { 
            string authors = AuthorsField.Text;
            string bookName = BookNameField.Text;
            string topics = BookTopicsField.Text;
            string numberOfExamples = NumberOfExamplesField.Text;
            string result = manageBookController.AddBook(bookName, numberOfExamples, authors, topics);
            if (numberOfExamples.Equals("1")) {
                MessageBox.Show(result, result.Equals($"You added a book") ? "Operation successful" : "Something went wrong");
            }
            else
            {
                MessageBox.Show(result, result.Equals($"You added some books") ? "Operation successful" : "Something went wrong");
            }
        }
    }
}
