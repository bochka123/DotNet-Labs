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
using WebLibraryApp.PL.Controllers;
using Ninject;
using WebLibraryApp.BLL.Interfaces;

namespace WebLibraryApp.PL.Views
{
    public partial class ProfileWindow : Form
    {
        string login;
        UserViewModel user;
        UserCardViewModel userCard;
        private AuthorizationController authorizationController;
        private RegistrationController registrationController;
        public ProfileWindow(string login)
        {
            IKernel kernel = Program.Kernel;
            var authorizationService = kernel.Get<IAuthorizationService>();
            var registrationService = kernel.Get<IRegistrationService>();
            authorizationController = new AuthorizationController(authorizationService);
            registrationController = new RegistrationController(registrationService);
            InitializeComponent();
            this.login = login;
            user = authorizationController.FindUserByLogin(login);
            userCard = authorizationController.FindUserCardByLogin(login);
            LabelFirstName.Text = $"First name: {user.FirstName}";
            LabelSecondName.Text = $"Second name: {user.SecondName}";
            LabelLogin.Text = $"Login: {user.Login}";
            LabelDate.Text = $"Date of making a card: {userCard.DateOfMaking}";
            LabelBooks.Text = "Books you have: ";
            foreach (var book in userCard.Books.ToList())
            {
                LabelBooks.Text += $"{book.Name} \n                ";
            }
        }

        private void MainWindowButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow mainWindow = new MainWindow(login);
            mainWindow.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AuthorizationWindow authorizationWindow = new AuthorizationWindow();
            authorizationWindow.Show();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            string result = registrationController.DeleteUser(user.Id);
            if (result.Equals("User was deleted"))
            {
                this.Close();
                AuthorizationWindow authorizationWindow = new AuthorizationWindow();
                authorizationWindow.Show();
                MessageBox.Show($"User {user.Login} was deleted", result);
            }
            else
            {
                MessageBox.Show(result, "Deleting failed");
            }
        }
    }
}
