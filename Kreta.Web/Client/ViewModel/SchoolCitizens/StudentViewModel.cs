using Kreta.HttpService.Service;
using Kreta.Shared.Models;
using MudBlazor;

namespace Kreta.Web.Client.ViewModel.SchoolCitizens
{
    public class StudentViewModel : IStudenViewModel
    {
        private IStudentService? _studentService;
        public string SerchedName { get; set; } = string.Empty;
        public uint FileteredMinBirthYear { get; set; } = 0;
        public uint FilteredMaxBirthYear { get;set; } = uint.MaxValue;

        public StudentViewModel(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public async Task<TableData<Student>> InitializeAsync()
        {
            if (_studentService is not null)
            {
                List<Student> students = await _studentService.SelectAllStudent();
                SetFilteredMinMaxYear(students);
                TableData<Student> data = new()
                {
                    Items = students,
                    TotalItems = students.Count,
                };
                return data;
            }
            return new TableData<Student> { Items = new List<Student>() };
        }

        public async Task SearchStudentByName(string name)
        {
            SerchedName = name;

        }

        public async Task FilterStudentByBirthYear()
        {
        }
        private void SetFilteredMinMaxYear(List<Student> students)
        {
            FileteredMinBirthYear = (uint) students.Select(student => student.BirthsDay.Year).Min();
            FilteredMaxBirthYear = (uint)students.Select(student => student.BirthsDay.Year).Max();
        }
    }
}
