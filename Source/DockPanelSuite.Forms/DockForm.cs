namespace DockPanelSuite.Forms {

    public partial class DockForm : Form {

        public DockForm() {
            InitializeComponent();
        }

        private void ToolStripPanelButton_Click(object sender, EventArgs e) {
            var panel = new PanelForm();
            panel.Show(DockPanel);
        }
    }
}