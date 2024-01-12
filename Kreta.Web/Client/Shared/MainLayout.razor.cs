namespace Kreta.Web.Client.Shared
{
    public partial class MainLayout
    {
        private bool _drawerOpen = true;
        private bool _isCurrentLightTheme = true;
        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}