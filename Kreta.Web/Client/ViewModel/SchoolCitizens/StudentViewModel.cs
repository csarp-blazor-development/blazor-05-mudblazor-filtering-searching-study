using Kreta.HttpService.Service;
using Kreta.Shared.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace Kreta.Web.Client.ViewModel.SchoolCitizens
{
    public class StudentViewModel : IStudenViewModel
    {
        [Inject] public IStudentService? StudentService { get; set; }
        public string SerchedName { get; set; } = string.Empty;
        public uint SearchedMinYear { get; set; } = 0;
        public uint SearchedMaxYear { get;set; } = uint.MaxValue;
        public async Task<TableData<Student>> InitializeAsync()
        {
            if (StudentService is not null)
            {
                List<Student> students = await StudentService.SelectAllStudent();
                TableData<Student> data = new()
                {
                    Items = students,
                    TotalItems = students.Count,
                };
                return data;
            }
            return new TableData<Student> { Items = new List<Student>() };
        }

    }
}
