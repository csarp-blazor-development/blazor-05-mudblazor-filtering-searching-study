using Kreta.Shared.Models;
using MudBlazor;

namespace Kreta.Web.Client.ViewModel.SchoolCitizens
{
    public interface IStudenViewModel
    {
        public string SerchedName { get; set; }
        public uint FileteredMinYear { get; set; }
        public uint FilteredMaxYear { get; set; }
        public Task<TableData<Student>> InitializeAsync();
    }
}
