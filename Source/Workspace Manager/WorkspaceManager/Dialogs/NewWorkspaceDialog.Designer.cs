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
            SaveButton = new System.Windows.Forms.Button();
            WorkspaceNameLabel = new System.Windows.Forms.Label();
            WorkspaceNameText = new System.Windows.Forms.TextBox();
            MessageErrorLabel = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            SaveButton.Location = new System.Drawing.Point(436, 52);
            SaveButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(130, 35);
            SaveButton.TabIndex = 1;
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // WorkspaceNameLabel
            // 
            WorkspaceNameLabel.Location = new System.Drawing.Point(12, 13);
            WorkspaceNameLabel.Name = "WorkspaceNameLabel";
            WorkspaceNameLabel.Size = new System.Drawing.Size(111, 31);
            WorkspaceNameLabel.TabIndex = 2;
            WorkspaceNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WorkspaceNameText
            // 
            WorkspaceNameText.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            WorkspaceNameText.Location = new System.Drawing.Point(129, 13);
            WorkspaceNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            WorkspaceNameText.Name = "WorkspaceNameText";
            WorkspaceNameText.Size = new System.Drawing.Size(437, 31);
            WorkspaceNameText.TabIndex = 0;
            WorkspaceNameText.TextChanged += WorkspaceNameText_TextChanged;
            WorkspaceNameText.KeyDown += WorkspaceNameText_KeyDown;
            // 
            // MessageErrorLabel
            // 
            MessageErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            MessageErrorLabel.ForeColor = System.Drawing.Color.Red;
            MessageErrorLabel.Location = new System.Drawing.Point(12, 52);
            MessageErrorLabel.Name = "MessageErrorLabel";
            MessageErrorLabel.Size = new System.Drawing.Size(418, 35);
            MessageErrorLabel.TabIndex = 3;
            MessageErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewWorkspaceDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(578, 99);
            Controls.Add(MessageErrorLabel);
            Controls.Add(SaveButton);
            Controls.Add(WorkspaceNameLabel);
            Controls.Add(WorkspaceNameText);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewWorkspaceDialog";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label WorkspaceNameLabel;
        private System.Windows.Forms.TextBox WorkspaceNameText;
        private System.Windows.Forms.Label MessageErrorLabel;
    }
}