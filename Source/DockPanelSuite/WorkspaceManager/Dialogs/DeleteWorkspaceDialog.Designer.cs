namespace Nulo.Modules.WorkspaceManager {
    partial class DeleteWorkspaceDialog {
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
            LabelSelected = new System.Windows.Forms.Label();
            UserWorkspaceOptions = new System.Windows.Forms.ComboBox();
            DeleteButton = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // LabelSelected
            // 
            LabelSelected.Location = new System.Drawing.Point(12, 16);
            LabelSelected.Name = "LabelSelected";
            LabelSelected.Size = new System.Drawing.Size(111, 31);
            LabelSelected.TabIndex = 0;
            LabelSelected.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UserWorkspaceOptions
            // 
            UserWorkspaceOptions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            UserWorkspaceOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            UserWorkspaceOptions.FormattingEnabled = true;
            UserWorkspaceOptions.Location = new System.Drawing.Point(129, 15);
            UserWorkspaceOptions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            UserWorkspaceOptions.Name = "UserWorkspaceOptions";
            UserWorkspaceOptions.Size = new System.Drawing.Size(337, 33);
            UserWorkspaceOptions.TabIndex = 1;
            // 
            // DeleteButton
            // 
            DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            DeleteButton.Location = new System.Drawing.Point(336, 54);
            DeleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new System.Drawing.Size(130, 35);
            DeleteButton.TabIndex = 2;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += RemoveButton_Click;
            // 
            // DeleteWorkspaceDialog
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.Window;
            ClientSize = new System.Drawing.Size(478, 99);
            Controls.Add(DeleteButton);
            Controls.Add(LabelSelected);
            Controls.Add(UserWorkspaceOptions);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteWorkspaceDialog";
            ShowIcon = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label LabelSelected;
        private System.Windows.Forms.ComboBox UserWorkspaceOptions;
        private System.Windows.Forms.Button DeleteButton;
    }
}