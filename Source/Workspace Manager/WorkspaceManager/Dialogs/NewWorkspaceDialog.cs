using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager {

    internal partial class NewWorkspaceDialog : Form {

        #region Constants

        private const string BADCHARS = "\\/:*?\"<>|";

        #endregion Constants

        #region Fields

        private readonly List<DefaultWorkspace> defaultLayouts;
        private readonly List<string> userLayouts;
        private readonly Texts texts;
        private bool flag = false;

        #endregion Fields

        #region Properties

        public string WorkspaceName { get; private set; }

        #endregion Properties

        #region Constructors

        public NewWorkspaceDialog(List<string> userLayouts, List<DefaultWorkspace> defaultLayouts, Texts texts, DockContentColorPalette colorPalette) {
            InitializeComponent();
            this.userLayouts = userLayouts;
            this.defaultLayouts = defaultLayouts;
            this.texts = texts;
            WorkspaceNameText_TextChanged(null, null);

            Text = this.texts.NewWorkspaceTitle;
            WorkspaceNameLabel.Text = $"{this.texts.NewWorkspaceName}:";
            SaveButton.Text = this.texts.CommandSave;

            BackColor = colorPalette.Background;
            ForeColor = colorPalette.TextColor;
        }

        #endregion Constructors

        #region Privates Methods

        private void SetName() {
            flag = true;
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
                SaveButton.Enabled = false;
                return false;
            }

            foreach(var badChar in BADCHARS) {
                if(name.Contains(badChar)) {
                    MessageErrorLabel.Text = $"{texts.NewWorkspaceMessageErrorInvalidCharacter}: {BADCHARS}";
                    SaveButton.Enabled = false;
                    return false;
                }
            }

            SaveButton.Enabled = true;
            return true;
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            SetName();
        }

        private void WorkspaceNameText_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Enter) { SetName(); }
        }

        private void WorkspaceNameText_TextChanged(object sender, EventArgs e) {
            if(flag) {
                if(IsValidFileName(WorkspaceNameText.Text.Trim())) { MessageErrorLabel.Text = string.Empty; }
                if(WorkspaceNameText.Text.Length == 0) {
                    MessageErrorLabel.Text = string.Empty;
                    SaveButton.Enabled = false;
                }
            } else {
                SaveButton.Enabled = WorkspaceNameText.Text.Length != 0;
            }
        }

        #endregion Privates Methods
    }
}