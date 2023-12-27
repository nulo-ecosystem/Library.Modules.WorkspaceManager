using DockPanelSuite.Forms.Panels;
using Nulo.Modules.DockPanelSuite.Docking;

namespace DockPanelSuite.Forms.Pages {

    public partial class MainPage : Form {

        public MainPage() => InitializeComponent();

        private void DockForm_Load(object sender, EventArgs e) {
            DockPanel.Controls.Add(Program.WorkspaceManager.DockPanel);
            Program.WorkspaceManager.Style = WorkspaceManager_Style;
            Program.WorkspaceManager.DropDown = ToolStripLayouts;
            Program.WorkspaceManager.Init();
        }
        private void DockForm_FormClosing(object sender, FormClosingEventArgs e) {
            Program.WorkspaceManager.Dispose();
        }

        private void WorkspaceManager_Style(ToolStripExtender style) {
            BackColor = Program.WorkspaceManager.Theme.ColorPalette.CommandBarMenuDefault.Background;

            style.SetStyle(MenuStrip);
            style.SetStyle(ToolStrip);
            style.SetStyle(StatusStrip);
        }

        private void MenuStripFileExit_Click(object sender, EventArgs e) => Application.Exit();
        private void MenuStripThemeLight_Click(object sender, EventArgs e) => Program.WorkspaceManager.SetTheme("light");
        private void MenuStripThemeDark_Click(object sender, EventArgs e) => Program.WorkspaceManager.SetTheme("dark");
        private void MenuStripWindowLeftPanel_Click(object sender, EventArgs e) => Program.WorkspaceManager.OpenPanel<LeftPanel>();
        private void MenuStripWindowRightPanel_Click(object sender, EventArgs e) => Program.WorkspaceManager.OpenPanel<RightPanel>();
        private void MenuStripWindowBottomPanel_Click(object sender, EventArgs e) => Program.WorkspaceManager.OpenPanel<BottomPanel>();
        private void MenuStripWindowDocumentPanel_Click(object sender, EventArgs e) => Program.WorkspaceManager.OpenPanel<DocumentPanel>();
        private void MenuStripWindowFloatPanel_Click(object sender, EventArgs e) => Program.WorkspaceManager.OpenPanel<FloatPanel>();
    }
}