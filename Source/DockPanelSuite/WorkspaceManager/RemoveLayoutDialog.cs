using System.Collections.Generic;
using System.Windows.Forms;

namespace Nulo.Modules.DockPanelSuite.WorkspaceManager {

    public partial class RemoveWorkspaceDialog : Form {

        public int IndexWorkspace { get; private set; }

        public RemoveWorkspaceDialog(List<string> layouts) {
            InitializeComponent();
            foreach (var layout in layouts) UserLayoutOptions.Items.Add(layout);
        }

        private void RemoveButton_Click(object sender, System.EventArgs e) {
            if (UserLayoutOptions.SelectedIndex == -1) return;

            IndexWorkspace = UserLayoutOptions.SelectedIndex;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}