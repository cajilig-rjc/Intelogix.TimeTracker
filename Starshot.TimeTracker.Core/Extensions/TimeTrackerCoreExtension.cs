using Microsoft.Extensions.DependencyInjection;
using Starshot.TimeTracker.Core.Services.EmployeeService;

namespace Starshot.TimeTracker.Core.Extensions
{
    public static class TimeTrackerCoreExtension
    {
        public static IServiceCollection AddTimeTrackerCoreService(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeServiceManager>();
            return services;
        }
    }
}
