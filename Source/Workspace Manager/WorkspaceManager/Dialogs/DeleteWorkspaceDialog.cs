using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager {

    internal partial class DeleteWorkspaceDialog : Form {

        #region Properties

        public int IndexWorkspace { get; private set; }

        #endregion Properties

        #region Constructors

        public DeleteWorkspaceDialog(List<string> layouts, Texts texts, DockContentColorPalette colorPalette) {
            InitializeComponent();
            foreach(var layout in layouts) { UserWorkspaceOptions.Items.Add(layout); }
            UserWorkspaceOptions_SelectedIndexChanged(null, null);

            Text = texts.DeleteWorkspaceTitle;
            LabelSelected.Text = $"{texts.DeleteWorkspaceSelect}:";
            DeleteButton.Text = texts.CommandDelete;

            BackColor = colorPalette.Background;
            ForeColor = colorPalette.TextColor;
        }

        #endregion Constructors

        #region Private Methods

        private void RemoveButton_Click(object sender, EventArgs e) {
            if(UserWorkspaceOptions.SelectedIndex == -1) { return; }

            IndexWorkspace = UserWorkspaceOptions.SelectedIndex;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void UserWorkspaceOptions_SelectedIndexChanged(object sender, EventArgs e) {
            DeleteButton.Enabled = UserWorkspaceOptions.SelectedIndex != -1;
        }

        private void UserWorkspaceOptions_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) { RemoveButton_Click(null, null); }
        }

        #endregion Private Methods
    }
}