namespace Nulo.Modules.WorkspaceManager {

    internal partial class NewWorkspaceDialog : Form {
        public string WorkspaceName { get; private set; }
        private const string BADCHARS = "\\/:*?\"<>|";
        private readonly List<DefaultWorkspace> defaultLayouts;
        private readonly List<string> userLayouts;
        private readonly Texts texts;

        public NewWorkspaceDialog(List<string> userLayouts, List<DefaultWorkspace> defaultLayouts, Texts texts) {
            InitializeComponent();
            this.userLayouts = userLayouts;
            this.defaultLayouts = defaultLayouts;
            this.texts = texts;

            Text = this.texts.NewWorkspaceTitle;
            WorkspaceNameLabel.Text = $"{this.texts.NewWorkspaceName}:";
            SaveButton.Text = this.texts.CommandSave;
        }

        private void SetName() {
            var value = WorkspaceNameText.Text.Trim();
            if(IsValidFileName(value)) {
                WorkspaceName = value;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool IsValidFileName(string name) {
            if(string.IsNullOrEmpty(name)) { return false; }

            if(userLayouts.Contains(name) || defaultLayouts.FirstOrDefault(a => a.Name.Equals(name)) != null) {
                MessageErrorLabel.Text = texts.NewWorkspaceMessageErrorDuplicate;
                return false;
            }

            foreach(var badChar in BADCHARS) {
                if(name.Contains(badChar)) {
                    MessageErrorLabel.Text = $"{texts.NewWorkspaceMessageErrorInvalidCharacter}: {BADCHARS}";
                    return false;
                }
            }

            return true;
        }

        private void SaveButton_Click(object sender, System.EventArgs e) => SetName();

        private void WorkspaceNameText_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) { SetName(); }
        }

        private void WorkspaceNameText_TextChanged(object sender, System.EventArgs e) => MessageErrorLabel.Text = string.Empty;
    }
}