using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Panels {

    public partial class DocumentPanel : DockContent {

        public DocumentPanel() => InitializeComponent();

        public override void SetColors(DockContentColorPalette colorPalette) {
            BackColor = colorPalette.Background;
        }
        public override void SetStyle(ToolStripExtender style) {
            style.SetStyle(ToolStrip);
        }
        public override void UpdateContent() {
            ToolStripStatus.Text = $"Updated on {DateTime.Now}";
        }
    }
}