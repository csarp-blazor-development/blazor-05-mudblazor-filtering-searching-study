namespace Kreta.Web.Client.ViewModel.SchoolCitizens
{
    public class StudentViewModel : IStudenViewModel
    {
        public string SerchedName { get; set; } = string.Empty;
        public uint SearchedMinYear { get; set; } = 0;
        public uint SearchedMaxYear { get;set; } = uint.MaxValue;

    }
}
