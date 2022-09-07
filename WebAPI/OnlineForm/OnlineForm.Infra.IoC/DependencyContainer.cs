using Microsoft.Extensions.DependencyInjection;
using OnlineForm.Domain.Repositories;
using OnlineForm.Infrastructure.Repositories;
using OnlineForm.Service.Interfaces;
using OnlineForm.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineForm.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Service Layer
            services.AddScoped<IUserService, UserService>();

            //Infra.Data Layer
            services.AddScoped<IUserRepository, UserRepository>();
        }
    }
}
