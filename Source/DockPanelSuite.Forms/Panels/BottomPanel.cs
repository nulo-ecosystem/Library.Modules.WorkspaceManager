using Nulo.Modules.DockPanelSuite.Docking;

namespace DockPanelSuite.Forms.Panels {

    public partial class BottomPanel : DockContent {

        public BottomPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
    }
}