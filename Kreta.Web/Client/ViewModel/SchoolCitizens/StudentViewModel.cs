using Kreta.HttpService.Service;
using Kreta.Shared.Models;
using MudBlazor;

namespace Kreta.Web.Client.ViewModel.SchoolCitizens
{
    public class StudentViewModel : IStudenViewModel
    {
        private IStudentService? _studentService;

        public List<Student> StudentItems { get; set; } = new List<Student>();
        public string SerchedName { get; set; } = string.Empty;
        public uint FileteredMinBirthYear { get; set; } = 0;
        public uint FilteredMaxBirthYear { get;set; } = uint.MaxValue;

        public StudentViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task InitializeAsync()
        {
            if (_studentService is not null)
            {
                StudentItems = await _studentService.SelectAllStudent();
                SetFilteredMinMaxYear();
            }
        }

        public async Task SearchStudentByName(string name)
        {
            SerchedName = name;
            if (_studentService != null)
            {
                StudentItems = await _studentService.SearchAndFilterStudents(this.ToStudentQueryParameters);
            }
        }

        public async Task FilterStudentByBirthYear()
        {
            if (_studentService != null)
            {
                StudentItems = await _studentService.SearchAndFilterStudents(this.ToStudentQueryParameters);
            }
        }
        private void SetFilteredMinMaxYear()
        {
            FileteredMinBirthYear = (uint) StudentItems.Select(student => student.BirthsDay.Year).Min();
            FilteredMaxBirthYear = (uint) StudentItems.Select(student => student.BirthsDay.Year).Max();
        }
    }
}
