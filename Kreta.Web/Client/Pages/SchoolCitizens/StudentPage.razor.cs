using Kreta.HttpService.Service;
using Kreta.Shared.Models;
using Kreta.Web.Client.ViewModel.SchoolCitizens;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Kreta.Web.Client.Pages.SchoolCitizens
{
    public partial class StudentPage
    {
        [Inject] IStudenViewModel? StudentViewModel { get; set; }
        public async Task<TableData<Student>> ReloadDataAsync(TableState state)
        {
            if (StudentViewModel is not null)
            {
                return await StudentViewModel.InitializeAsync();
            }
            return new TableData<Student> { Items = new List<Student>() };
        }
    }
}
