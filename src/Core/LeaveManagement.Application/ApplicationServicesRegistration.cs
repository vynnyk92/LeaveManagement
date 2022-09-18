using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace LeaveManagement.Application
{
    public  static class ApplicationServicesRegistration
    {
        public static IServiceCollection ConfigureApplicationServices(this IServiceCollection serviceCollection)
        {
            return serviceCollection
                        .AddAutoMapper(Assembly.GetExecutingAssembly())
                        .AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
