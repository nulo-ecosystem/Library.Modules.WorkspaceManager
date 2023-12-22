using Nulo.Modules.DockPanelSuite.Docking;

namespace DockPanelSuite.Forms.Panels {

    public partial class FloatPanel : DockContent {

        public FloatPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
    }
}