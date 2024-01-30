using Kreta.Shared.Parameters;

namespace Kreta.Web.Client.ViewModel.SchoolCitizens
{
    public static class StudentViewModelExtension
    {
        public static StudentQueryParameters ToStudentQueryParameters(this StudentViewModel studentViewModel)
        {
            return new StudentQueryParameters
            {
                MinYearOfBirth = studentViewModel.FileteredMinBirthYear,
                MaxYearOfBirth = studentViewModel.FilteredMaxBirthYear,
                Name = studentViewModel.SerchedName
            };
        }
    }
}
