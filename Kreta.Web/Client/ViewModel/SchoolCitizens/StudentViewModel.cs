namespace Kreta.Web.Client.ViewModel.SchoolCitizens
{
    public class StudentViewModel
    {
        public string SerchedName { get; set; } = string.Empty;
        public uint SearchedMinYar { get; set; } = 0;
        public uint SearchedMaxYar { get;set; } = uint.MaxValue;

    }
}
