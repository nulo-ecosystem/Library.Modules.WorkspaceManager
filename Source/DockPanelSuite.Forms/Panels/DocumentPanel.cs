using Nulo.Modules.DockPanelSuite.Docking;

namespace DockPanelSuite.Forms.Panels {

    public partial class DocumentPanel : DockContent {

        public DocumentPanel() {
            InitializeComponent();
        }

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
    }
}