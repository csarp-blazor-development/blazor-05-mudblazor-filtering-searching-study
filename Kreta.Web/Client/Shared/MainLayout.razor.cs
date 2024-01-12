using MudBlazor;

namespace Kreta.Web.Client.Shared
{
    public partial class MainLayout
    {
        private bool _drawerOpen = true;
        private bool _isCurrentLightTheme = true;
        private MudTheme _darkMudTheme = new MudTheme();
        private MudTheme _lightMudTheme = new MudTheme();
        private MudTheme _currentTheme = new MudTheme();
        void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }
    }
}