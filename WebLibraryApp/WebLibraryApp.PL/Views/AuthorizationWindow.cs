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
    public partial class AuthorizationWindow : Form
    {
        public MainWindow mainWindow;
        private RegistrationController registrationController;
        private AuthorizationController authorizationController;
        public AuthorizationWindow()    
        {
            IKernel kernel = Program.Kernel;
            var registrationService = kernel.Get<IRegistrationService>();
            var authorizationService = kernel.Get<IAuthorizationService>();
            registrationController = new RegistrationController(registrationService);
            authorizationController = new AuthorizationController(authorizationService);
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string firstName = FirstName.Text;
            string secondName = SecondName.Text;
            string login = RegisterLogin.Text;
            string password = RegisterPassword.Text;
            int id = login.GetHashCode();
            UserViewModel newUser = new UserViewModel
            {
                Id = id,
                FirstName = firstName,
                SecondName = secondName,
                Login = login,
                Password = password
            };
            string result = registrationController.Register(newUser);
            MessageBox.Show(result, "Registration result");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string login = LoginLogin.Text;
            string password = LoginPassword.Text;
            string result = authorizationController.Login(login, password);
            if (result.StartsWith("U"))
            {
                this.Hide();
                mainWindow = new MainWindow(login);
                mainWindow.Show();
            }else{
                MessageBox.Show(result, "Login result");
            }
        }
    }
}
