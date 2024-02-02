namespace Nulo.Modules.WorkspaceManager {
    internal partial class NewWorkspaceDialog {
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
            WorkspaceNameLabel = new Label();
            WorkspaceNameText = new TextBox();
            MessageErrorLabel = new Label();
            SaveButton = new ControlKit.Buttons.SmartPrimaryButton();
            SuspendLayout();
            // 
            // WorkspaceNameLabel
            // 
            WorkspaceNameLabel.Location = new Point(12, 30);
            WorkspaceNameLabel.Name = "WorkspaceNameLabel";
            WorkspaceNameLabel.Size = new Size(111, 31);
            WorkspaceNameLabel.TabIndex = 2;
            WorkspaceNameLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // WorkspaceNameText
            // 
            WorkspaceNameText.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            WorkspaceNameText.Location = new Point(129, 30);
            WorkspaceNameText.Margin = new Padding(3, 4, 3, 4);
            WorkspaceNameText.Name = "WorkspaceNameText";
            WorkspaceNameText.Size = new Size(487, 31);
            WorkspaceNameText.TabIndex = 0;
            WorkspaceNameText.TextChanged += WorkspaceNameText_TextChanged;
            WorkspaceNameText.KeyDown += WorkspaceNameText_KeyDown;
            // 
            // MessageErrorLabel
            // 
            MessageErrorLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MessageErrorLabel.ForeColor = Color.Red;
            MessageErrorLabel.Location = new Point(12, 95);
            MessageErrorLabel.Name = "MessageErrorLabel";
            MessageErrorLabel.Size = new Size(438, 35);
            MessageErrorLabel.TabIndex = 3;
            MessageErrorLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.BackColor = SystemColors.Highlight;
            SaveButton.BorderRadius = 20;
            SaveButton.DisabledBackColor = Color.FromArgb(132, 179, 220);
            SaveButton.DisabledForeColor = Color.LightCyan;
            SaveButton.FlatAppearance.BorderSize = 0;
            SaveButton.FlatStyle = FlatStyle.Flat;
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(456, 92);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(160, 40);
            SaveButton.TabIndex = 4;
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // NewWorkspaceDialog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(628, 144);
            Controls.Add(SaveButton);
            Controls.Add(MessageErrorLabel);
            Controls.Add(WorkspaceNameLabel);
            Controls.Add(WorkspaceNameText);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewWorkspaceDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label WorkspaceNameLabel;
        private System.Windows.Forms.TextBox WorkspaceNameText;
        private System.Windows.Forms.Label MessageErrorLabel;
        private ControlKit.Buttons.SmartPrimaryButton SaveButton;
    }
}