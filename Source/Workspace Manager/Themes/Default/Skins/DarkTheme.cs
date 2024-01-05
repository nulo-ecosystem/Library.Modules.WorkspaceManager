namespace Nulo.Modules.WorkspaceManager.Docking {

    using Themes.Default;

    public class DarkTheme : Theme {

        public DarkTheme() : base(Decompress(Resources.default_dark_theme)) {
            DockContentColorPalette = new DockContentColorPalette {
                Background = Color.FromArgb(37, 37, 37),
                DarkBackground = Color.FromArgb(30, 30, 30),
                UnfocusedBackColor = Color.Gray,
                TextColor = Color.White,
                Control = ColorPalette.CommandBarMenuDefault.Background
            };
        }
    }
}