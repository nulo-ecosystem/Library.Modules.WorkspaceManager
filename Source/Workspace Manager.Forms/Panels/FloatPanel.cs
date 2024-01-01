using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Panels {

    public partial class FloatPanel : DockContent {

        public FloatPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
    }
}