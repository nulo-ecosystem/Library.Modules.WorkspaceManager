using Nulo.Modules.DockPanelSuite.Docking;

namespace DockPanelSuite.Forms.Panels {

    public partial class RightPanel : DockContent {

        public RightPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
    }
}
