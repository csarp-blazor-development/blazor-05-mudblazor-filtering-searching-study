using Kreta.Shared.Models;
using MudBlazor;

namespace Kreta.Web.Client.ViewModel.SchoolCitizens
{
    public interface IStudenViewModel
    {
        public List<Student> StudentItems { get; set; }
        public string SerchedName { get; set; }
        public uint FileteredMinBirthYear { get; set; }
        public uint FilteredMaxBirthYear { get; set; }
        public Task InitializeAsync();
        public Task SearchStudentByName(string name);
        public Task FilterStudentByBirthYear();
        public Task ResetFilterAndSerachParameter();
    }
}
