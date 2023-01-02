using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebLibraryApp.PL.Views;
using WebLibraryApp.BLL.Services;
using Microsoft.Extensions.DependencyInjection;
using WebLibraryApp.BLL.Infrastructure;
using Ninject;

namespace WebLibraryApp.PL
{
    public static class Program
    {
        public static IKernel Kernel { get; set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Kernel = new StandardKernel();
            Kernel.Load(new NinjectClass());
            Application.Run(new AuthorizationWindow());

        }
    }
}
