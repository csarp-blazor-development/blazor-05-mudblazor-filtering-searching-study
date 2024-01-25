namespace Kreta.Shared.Parameters
{
    public class StudentQueryParameters
    {
        public uint MinYearOfBirth { get; set; }
        public uint MaxYearOfBirth { get; set; } = (uint)DateTime.Now.Year;

        public bool ValidYearRange => MaxYearOfBirth > MinYearOfBirth;

        public string Name { get; set; } = string.Empty;
    }
}
