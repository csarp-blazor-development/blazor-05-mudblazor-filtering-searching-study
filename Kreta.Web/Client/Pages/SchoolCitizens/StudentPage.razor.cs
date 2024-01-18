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
            return new TableData<Student>();
        }
    }
}
