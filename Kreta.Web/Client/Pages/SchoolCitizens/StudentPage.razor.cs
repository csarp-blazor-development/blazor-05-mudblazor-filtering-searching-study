using Kreta.HttpService.Service;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Kreta.Web.Client.Pages.SchoolCitizens
{
    public partial class StudentPage
    {
        [Inject] IStudentService? StudentService { get; set; }
        public async Task<TableData<Student>> ReloadDataAsync(TableState state)
        {

        }
    }
}
