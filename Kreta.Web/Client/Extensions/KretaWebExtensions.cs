using Kreta.HttpService.Service;
using Kreta.Web.Client.ViewModel.SchoolCitizens;

namespace Kreta.Web.Client.Extensions
{
    public static class KretaWebExtensions
    {
        public static void ConfigureKretaViewModels(this IServiceCollection services)
        {
            services.AddScoped<IStudenViewModel, StudentViewModel>();
        }
        public static void ConfigureKretaWebServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
