namespace Nulo.Modules.WorkspaceManager.Docking {

    using Themes.Default;

    public class LightTheme : Theme {

        public LightTheme() : base(Decompress(Resources.default_light_theme)) {
            DockContentColorPalette = new DockContentColorPalette {
                Background = Color.White,
                DarkBackground = Color.FromArgb(250, 250, 250),
                UnfocusedBackColor = SystemColors.Control,
                TextColor = Color.Black,
                Control = ColorPalette.CommandBarMenuDefault.Background
            };
        }
    }
}