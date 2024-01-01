using System.Drawing;
using System.Windows.Forms;

namespace Nulo.Panels {
    partial class DocumentPanel {
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
            ToolStrip = new ToolStrip();
            ToolStripStatus = new ToolStripLabel();
            ToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip
            // 
            ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip.ImageScalingSize = new Size(24, 24);
            ToolStrip.Items.AddRange(new ToolStripItem[] { ToolStripStatus });
            ToolStrip.Location = new Point(0, 0);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(800, 28);
            ToolStrip.TabIndex = 0;
            // 
            // ToolStripStatus
            // 
            ToolStripStatus.Name = "ToolStripStatus";
            ToolStripStatus.Size = new Size(0, 23);
            // 
            // DocumentPanel
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ToolStrip);
            Name = "DocumentPanel";
            ShowHint = Nulo.Modules.WorkspaceManager.Docking.DockState.Document;
            Text = "Document Panel";
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip ToolStrip;
        private ToolStripLabel ToolStripStatus;
    }
}