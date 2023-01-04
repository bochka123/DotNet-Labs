using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebLibraryApp.PL.Models;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.PL.Controllers;
using Ninject;

namespace WebLibraryApp.PL.Views
{
    public partial class MainWindow : Form
    {
        string login;
        private FindBookController findBookController;
        private AuthorizationController authorizationController;
        private ManageBookController manageBookController;
        UserCardViewModel userCard;
        public MainWindow(string login)
        {
            IKernel kernel = Program.Kernel;
            var findBookService = kernel.Get<IFindBookService>();
            var authorizationService = kernel.Get<IAuthorizationService>();
            var manageBookService = kernel.Get<IManageBookService>();
            findBookController = new FindBookController(findBookService);
            authorizationController = new AuthorizationController(authorizationService);
            manageBookController = new ManageBookController(manageBookService);
            InitializeComponent();
            this.login = login;
            ProfileButton.Text = login;
            List<BookViewModel> list = (List<BookViewModel>)findBookController.GetAllBooks();
            foreach (var i in list)
            {
                resultListBox.Items.Add(i.Name);
            }
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Profile profile = new Profile(login);
            profile.Show();
        }
        
        private void S_Click(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                case -1:
                    MessageBox.Show("You didn`t select anything", "Error");
                    break;
                case 0:
                    resultListBox.Items.Clear();
                    var booksByName = findBookController.FindBookByName(SearchField.Text);
                    foreach (var book in booksByName)
                    {
                        resultListBox.Items.Add(book.Name);
                    }
                    break;
                case 1:
                    resultListBox.Items.Clear();
                    var booksByAuthor = findBookController.FindBookByAuthorName(SearchField.Text);
                    foreach (var book in booksByAuthor)
                    {
                        resultListBox.Items.Add(book.Name);
                    }
                    break;
                case 2:
                    resultListBox.Items.Clear();
                    var booksByTopic = findBookController.FindBookByTopicName(SearchField.Text);
                    foreach (var book in booksByTopic)
                    {
                        resultListBox.Items.Add(book.Name);
                    }
                    break;
            }
        }

        private void resultListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string bookName = resultListBox.SelectedItem.ToString();
            List<BookViewModel> book = (List<BookViewModel>)findBookController.FindBookByName(bookName);
            LabelBookName.Text = $"Book name: {book.First().Name}";
            LabelNumberOfAvailable.Text = $"Number of available: {book.First().NumberOfAvailable}";
            LabelBookAuthor.Text = "Authors: ";
            foreach (var item in book.First().Authors)
            {
                LabelBookAuthor.Text += $"{item.Name} ";
            }
            LabelBookTopics.Text = "Book topics: ";
            foreach (var item in book.First().BookTopics)
            {
                LabelBookTopics.Text += $"{item.Topic} ";
            }
            userCard = authorizationController.FindUserCardByLogin(login);
            try
            {
                LabelNumberOfTaken.Text = userCard.Books.ToList().Count.ToString();
            }catch(ArgumentNullException)
            {
                LabelNumberOfTaken.Text = "Number of taken: 0";
            }
        }

        private void ButtonTake_Click(object sender, EventArgs e)
        {
            BookViewModel book = findBookController.FindBookByName(resultListBox.SelectedItem.ToString()).First();
            int bookId = book.Id;
            int userCardId = authorizationController.FindUserCardByLogin(login).Id;
            manageBookController.TakeBook(bookId, userCardId);
            MessageBox.Show($"You have taken {resultListBox.SelectedItem}", "Operation successful");
            LabelNumberOfAvailable.Text = $"Number of available: {book.NumberOfAvailable}";
        }

        private void ButtonGive_Click(object sender, EventArgs e)
        {

        }
    }
}
