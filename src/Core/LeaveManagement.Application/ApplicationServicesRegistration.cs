using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Extensions.DependencyInjection;

namespace LeaveManagement.Application
{
    public  static class ApplicationServicesRegistration
    {
        public static void ConfigureApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection
                .AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
