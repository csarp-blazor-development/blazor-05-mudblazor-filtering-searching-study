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

        protected async override Task OnInitializedAsync()
        {
            if (StudentViewModel is not null)
            {
                await StudentViewModel.InitializeAsync();
            }
        }
    }
}
