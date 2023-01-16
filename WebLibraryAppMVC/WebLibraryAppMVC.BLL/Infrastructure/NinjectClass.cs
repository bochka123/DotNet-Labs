using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using WebLibraryAppMVC.BLL.Interfaces;
using WebLibraryAppMVC.BLL.Services;
using WebLibraryAppMVC.DAL.Interfaces;
using WebLibraryAppMVC.DAL.Repositories;

namespace WebLibraryAppMVC.BLL.Infrastructure
{
    public class NinjectClass : NinjectModule
    {
        public override void Load()
        {
            Bind<IRegistrationAndAuthorizationService>().To<RegistrationAndAuthorizationService>();
            Bind<IFindBookService>().To<FindBookService>();
            Bind<IManageBookService>().To<ManageBookService>();
        }
    }
}