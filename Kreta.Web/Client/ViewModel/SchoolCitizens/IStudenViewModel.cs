namespace Kreta.Web.Client.ViewModel.SchoolCitizens
{
    public interface IStudenViewModel
    {
        public string SerchedName { get; set; }
        public uint SearchedMinYear { get; set; }
        public uint SearchedMaxYear { get; set; }
    }
}
