using Nulo.Modules.DockPanelSuite.Docking;
using Nulo.Modules.DockPanelSuite.LayoutManager;

namespace DockPanelSuite.Forms.Modules.LayoutManager {

    public class LayoutTheme : ILayoutTheme {

        public ThemeBase GetTheme(string theme) {
            if(Properties.Settings.Default.Theme.Equals(theme)) { return null; }
            theme ??= Properties.Settings.Default.Theme;

            if(theme.Equals("Light")) {
                Properties.Settings.Default.Theme = "Light";
                Properties.Settings.Default.Save();
                return new LightTheme();
            } else {
                Properties.Settings.Default.Theme = "Dark";
                Properties.Settings.Default.Save();
                return new DarkTheme();
            }
        }
    }
}