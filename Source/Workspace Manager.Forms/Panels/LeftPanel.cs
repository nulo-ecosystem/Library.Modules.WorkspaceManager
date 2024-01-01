using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Panels {

    public partial class LeftPanel : DockContent {

        public LeftPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
    }
}