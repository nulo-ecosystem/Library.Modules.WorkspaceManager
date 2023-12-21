using DockPanelSuite.Forms.Panels;
using Nulo.Modules.DockPanelSuite.Docking;

namespace DockPanelSuite.Forms.Pages {

    public partial class MainPage : Form {

        public MainPage() {
            InitializeComponent();
        }

        private void DockForm_Load(object sender, EventArgs e) {
            Program.LayoutManager.GetDock().Dock = DockStyle.Fill;
            DockPanel.Controls.Add(Program.LayoutManager.GetDock());
            Program.LayoutManager.SetStyle = LayoutManager_SetStyle;
            Program.LayoutManager.DropDown = ToolStripLayouts;
            Program.LayoutManager.Init();
        }
        private void DockForm_FormClosing(object sender, FormClosingEventArgs e) {
            Program.LayoutManager.Dispose();
        }

        private void LayoutManager_SetStyle(ToolStripExtender style) {
            BackColor = Program.LayoutManager.GetTheme().ColorPalette.CommandBarMenuDefault.Background;

            style.SetStyle(MenuStrip);
            style.SetStyle(ToolStrip);
            style.SetStyle(StatusStrip);
        }

        private void MenuStripFileExit_Click(object sender, EventArgs e) => Application.Exit();
        private void MenuStripThemeLight_Click(object sender, EventArgs e) => Program.LayoutManager.SetTheme("Light");
        private void MenuStripThemeDark_Click(object sender, EventArgs e) => Program.LayoutManager.SetTheme("Dark");
        private void MenuStripWindowLeftPanel_Click(object sender, EventArgs e) => Program.LayoutManager.OpenPanel<LeftPanel>();
        private void MenuStripWindowRightPanel_Click(object sender, EventArgs e) => Program.LayoutManager.OpenPanel<RightPanel>();
        private void MenuStripWindowBottomPanel_Click(object sender, EventArgs e) => Program.LayoutManager.OpenPanel<BottomPanel>();
        private void MenuStripWindowDocumentPanel_Click(object sender, EventArgs e) => Program.LayoutManager.OpenPanel<DocumentPanel>();
        private void MenuStripWindowFloatPanel_Click(object sender, EventArgs e) => Program.LayoutManager.OpenPanel<FloatPanel>();
    }
}