using System.Reflection;
using FluentValidation;
using LeaveManagement.Application.DTOs;
using LeaveManagement.Application.DTOs.LeaveRequest;
using LeaveManagement.Application.DTOs.Validators;
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
                        .AddMediatR(Assembly.GetExecutingAssembly())
                        .AddScoped<IValidator<CreateLeaveTypeDto>, CreateLeaveTypeDtoValidator>()
                        .AddScoped<IValidator<CreateLeaveAllocationDto>, CreateLeaveAllocationDtoValidator>()
                        .AddScoped<IValidator<CreateLeaveRequestDto>, CreateLeaveRequestDtoValidator>()
                ;
        }
    }
}
