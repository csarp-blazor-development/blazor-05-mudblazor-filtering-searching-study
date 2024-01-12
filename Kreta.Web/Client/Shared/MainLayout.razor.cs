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
        private void DrawerToggle()
        {
            _drawerOpen = !_drawerOpen;
        }

        protected override Task OnInitializedAsync()
        {
            InitializeLightTheme();
            InitializeDarkTheme();
            SetCurrentTheme();
            return base.OnInitializedAsync();
        }
        private void InitializeDarkTheme()
        {
            _darkMudTheme = new MudTheme()
            {
                Palette = new PaletteDark
                {
                    AppbarBackground = "#0097FF",
                    AppbarText = "#FFFFFF",

                    Background = "#001524",

                    Primary = "#007CD1",
                    Secondary = "#117CE1",
                    Tertiary = "#107C51",


                    TextPrimary = "#FFFFFF",
                    TextSecondary = "#FEFEFE",

                    DrawerBackground = "#093958",
                    DrawerText = "#FFFFFF",
                    Surface = "#093958",

                    ActionDefault = "#0097FF",
                    ActionDisabled = "#2F678C",
                    TextDisabled = "#B0B0B0"
                }
            };
        }

        private void InitializeLightTheme()
        {
            _lightMudTheme = new MudTheme()
            {
                Palette = new PaletteLight
                {
                    AppbarBackground = "#0097FF",
                    AppbarText = "#FFFFFF",

                    Background = "#F4FDFF",

                    Primary = "#007CD1",
                    Secondary = "#117CE1",
                    Tertiary = "#107C51",

                    TextPrimary = "#0C1217",
                    TextSecondary = "#0C1217",

                    DrawerBackground = "#C5E5FF",
                    DrawerText = "#0C1217",
                    Surface = "#E4FAFF",

                    ActionDefault = "#0C1217",
                    ActionDisabled = "#2F678C",
                    TextDisabled = "#676767"
                }
            };
        }

        private void SetCurrentTheme()
        {
            if (_isCurrentLightTheme)
            {
                _currentTheme = _lightMudTheme;
            }
            else
            {
                _currentTheme = _darkMudTheme;
            }
        }
    }
}