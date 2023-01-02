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
        private RegistrationController registrationController;
        public AuthorizationWindow()    
        {
            IKernel kernel = Program.Kernel;
            var registrationService = kernel.Get<IRegistrationService>();
            registrationController = new RegistrationController(registrationService);
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

        private void RegisterLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
