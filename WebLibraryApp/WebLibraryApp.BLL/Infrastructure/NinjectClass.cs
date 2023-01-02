using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.BLL.Services;

namespace WebLibraryApp.BLL.Infrastructure
{
    public class NinjectClass : NinjectModule
    {
        public override void Load()
        {
            Bind<IAuthorizationService>().To<AuthorizationService>();
            Bind<IFindBookService>().To<FindBookService>();
            Bind<IManageBookService>().To<ManageBookService>();
            Bind<IRegistrationService>().To<RegistrationService>();
        }
    }
}