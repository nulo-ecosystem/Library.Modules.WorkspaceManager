namespace DockPanelSuite.Forms {
    partial class DockForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DockForm));
            DockPanel = new Nulo.Modules.DockPanelSuite.Docking.DockPanel();
            LightTheme = new Nulo.Modules.DockPanelSuite.Docking.LightTheme();
            ToolStrip = new ToolStrip();
            ToolStripPanelButton = new ToolStripButton();
            ToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // DockPanel
            // 
            DockPanel.Dock = DockStyle.Fill;
            DockPanel.DockBackColor = Color.FromArgb(238, 238, 242);
            DockPanel.Location = new Point(0, 34);
            DockPanel.Name = "DockPanel";
            DockPanel.Padding = new Padding(6);
            DockPanel.ShowAutoHideContentOnHover = false;
            DockPanel.Size = new Size(1058, 630);
            DockPanel.TabIndex = 0;
            DockPanel.Theme = LightTheme;
            // 
            // ToolStrip
            // 
            ToolStrip.ImageScalingSize = new Size(24, 24);
            ToolStrip.Items.AddRange(new ToolStripItem[] { ToolStripPanelButton });
            ToolStrip.Location = new Point(0, 0);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(1058, 34);
            ToolStrip.TabIndex = 1;
            ToolStrip.Text = "toolStrip1";
            // 
            // ToolStripPanelButton
            // 
            ToolStripPanelButton.Image = (Image)resources.GetObject("ToolStripPanelButton.Image");
            ToolStripPanelButton.ImageTransparentColor = Color.Magenta;
            ToolStripPanelButton.Name = "ToolStripPanelButton";
            ToolStripPanelButton.Size = new Size(81, 29);
            ToolStripPanelButton.Text = "Panel";
            ToolStripPanelButton.Click += ToolStripPanelButton_Click;
            // 
            // DockForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(DockPanel);
            Controls.Add(ToolStrip);
            Name = "DockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Nulo.Modules.DockPanelSuite.Docking.DockPanel DockPanel;
        private ToolStrip ToolStrip;
        private ToolStripButton ToolStripPanelButton;
        private Nulo.Modules.DockPanelSuite.Docking.LightTheme LightTheme;
    }
}
