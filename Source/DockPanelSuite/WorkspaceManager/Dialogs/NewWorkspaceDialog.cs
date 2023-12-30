using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nulo.Modules.WorkspaceManager {

    public partial class NewWorkspaceDialog : Form {

        public string WorkspaceName { get; private set; }
        private const string BADCHARS = "\\/:*?\"<>|";
        private readonly List<DefaultWorkspace> defaultLayouts;
        private readonly List<string> userLayouts;

        public NewWorkspaceDialog(List<string> userLayouts, List<DefaultWorkspace> defaultLayouts, Texts texts) {
            InitializeComponent();
            this.userLayouts = userLayouts;
            this.defaultLayouts = defaultLayouts;
            Text = texts.NewWorkspaceTitle;
            LabelWorkspaceName.Text = $"{texts.NewWorkspaceName}:";
            AddButton.Text = texts.CommandSave;
        }

        private void SetName() {
            var value = TextWorkspaceName.Text.Trim();
            if(IsValidFileName(value)) {
                WorkspaceName = value;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
        private bool IsValidFileName(string name) {
            if(string.IsNullOrEmpty(name))
                return false;

            if(userLayouts.Contains(name) || defaultLayouts.FirstOrDefault(a => a.Name.Equals(name)) != null) {
                MessageBox.Show("O nome informado já existe! Por favor, tente novamente com outro nome", "Nome repetido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach(var badChar in BADCHARS) {
                if(name.IndexOf(badChar) != -1) {
                    MessageBox.Show($"O nome informado possui um ou mais caracteres inválidos! Por favor, evite usar {BADCHARS}", "Nome inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private void AddButton_Click(object sender, System.EventArgs e) => SetName();
        private void TextLayoutName_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter)
                SetName();
        }
    }
}
