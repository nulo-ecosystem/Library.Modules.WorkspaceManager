using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Panels {

    public partial class RightPanel : DockContent {

        public RightPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
    }
}
