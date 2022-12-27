using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using WebLibraryApp.BLL.Interfaces;
using WebLibraryApp.BLL.Services;
using WebLibraryApp.DAL.EF;
using WebLibraryApp.DAL.Interfaces;
using WebLibraryApp.DAL.Repoositories;

namespace WebLibraryApp.BLL.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IAuthorizationService, AuthorizationService>();
            services.AddScoped<IFindBookService, FindBookService>();
            services.AddScoped<IManageBookService, ManageBookService>();
            services.AddScoped<IRegistrationService, RegistrationService>();
            services.AddScoped<IUnitOfWork>(prov => new EFUnitOfWork());
            return services;
        }
    }
}
