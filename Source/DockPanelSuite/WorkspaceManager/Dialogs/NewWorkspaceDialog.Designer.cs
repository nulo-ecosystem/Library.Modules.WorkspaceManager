namespace Nulo.Modules.WorkspaceManager {
    partial class NewWorkspaceDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            AddButton = new System.Windows.Forms.Button();
            LabelWorkspaceName = new System.Windows.Forms.Label();
            TextWorkspaceName = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            AddButton.Location = new System.Drawing.Point(336, 52);
            AddButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new System.Drawing.Size(130, 35);
            AddButton.TabIndex = 1;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // LabelWorkspaceName
            // 
            LabelWorkspaceName.Location = new System.Drawing.Point(12, 13);
            LabelWorkspaceName.Name = "LabelWorkspaceName";
            LabelWorkspaceName.Size = new System.Drawing.Size(111, 31);
            LabelWorkspaceName.TabIndex = 2;
            LabelWorkspaceName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextWorkspaceName
            // 
            TextWorkspaceName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            TextWorkspaceName.Location = new System.Drawing.Point(129, 13);
            TextWorkspaceName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            TextWorkspaceName.Name = "TextWorkspaceName";
            TextWorkspaceName.Size = new System.Drawing.Size(337, 31);
            TextWorkspaceName.TabIndex = 0;
            TextWorkspaceName.KeyDown += TextLayoutName_KeyDown;
            // 
            // NewWorkspaceDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(478, 99);
            Controls.Add(AddButton);
            Controls.Add(LabelWorkspaceName);
            Controls.Add(TextWorkspaceName);
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

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label LabelWorkspaceName;
        private System.Windows.Forms.TextBox TextWorkspaceName;
    }
}