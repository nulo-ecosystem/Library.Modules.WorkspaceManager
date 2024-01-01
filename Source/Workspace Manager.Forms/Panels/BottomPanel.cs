using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Panels {

    public partial class BottomPanel : DockContent {

        public BottomPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
    }
}