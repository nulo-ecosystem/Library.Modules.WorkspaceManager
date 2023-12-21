using Nulo.Modules.DockPanelSuite.Docking;

namespace DockPanelSuite.Forms.Panels {

    public partial class LeftPanel : DockContent {

        public LeftPanel() {
            InitializeComponent();
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
    }
}