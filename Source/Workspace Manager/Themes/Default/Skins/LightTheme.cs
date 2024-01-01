namespace Nulo.Modules.WorkspaceManager.Docking {

    using Themes.Default;

    public class LightTheme : Theme {

        public LightTheme() : base(Decompress(Resources.default_light_theme)) {
            DockContentColorPalette = new DockContentColorPalette {
                Background = System.Drawing.Color.White,
                DarkBackground = System.Drawing.Color.FromArgb(250, 250, 250),
                UnfocusedBackColor = System.Drawing.SystemColors.Control,
                TextColor = System.Drawing.Color.Black,
                Control = ColorPalette.CommandBarMenuDefault.Background
            };
        }
    }
}