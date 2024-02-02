namespace Nulo.Modules.WorkspaceManager {
    internal partial class DeleteWorkspaceDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            LabelSelected = new Label();
            UserWorkspaceOptions = new ComboBox();
            DeleteButton = new ControlKit.Buttons.SmartPrimaryButton();
            SuspendLayout();
            // 
            // LabelSelected
            // 
            LabelSelected.Location = new Point(12, 30);
            LabelSelected.Name = "LabelSelected";
            LabelSelected.Size = new Size(111, 31);
            LabelSelected.TabIndex = 0;
            LabelSelected.TextAlign = ContentAlignment.MiddleRight;
            // 
            // UserWorkspaceOptions
            // 
            UserWorkspaceOptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UserWorkspaceOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            UserWorkspaceOptions.FormattingEnabled = true;
            UserWorkspaceOptions.Location = new Point(129, 30);
            UserWorkspaceOptions.Margin = new Padding(3, 4, 3, 4);
            UserWorkspaceOptions.Name = "UserWorkspaceOptions";
            UserWorkspaceOptions.Size = new Size(487, 33);
            UserWorkspaceOptions.TabIndex = 1;
            UserWorkspaceOptions.SelectedIndexChanged += UserWorkspaceOptions_SelectedIndexChanged;
            UserWorkspaceOptions.KeyDown += UserWorkspaceOptions_KeyDown;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteButton.BackColor = SystemColors.Highlight;
            DeleteButton.BorderRadius = 20;
            DeleteButton.DisabledBackColor = Color.FromArgb(132, 179, 220);
            DeleteButton.DisabledForeColor = Color.LightCyan;
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.ForeColor = Color.White;
            DeleteButton.Location = new Point(456, 92);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(160, 40);
            DeleteButton.TabIndex = 2;
            DeleteButton.UseVisualStyleBackColor = false;
            DeleteButton.Click += RemoveButton_Click;
            // 
            // DeleteWorkspaceDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(628, 144);
            Controls.Add(DeleteButton);
            Controls.Add(LabelSelected);
            Controls.Add(UserWorkspaceOptions);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteWorkspaceDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LabelSelected;
        private System.Windows.Forms.ComboBox UserWorkspaceOptions;
        private ControlKit.Buttons.SmartPrimaryButton DeleteButton;
    }
}