using Kreta.HttpService.Service;

namespace Kreta.Web.Client.Extensions
{
    public static class KretaWebExtensions
    {
        public static void ConfigureKretaWebServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
