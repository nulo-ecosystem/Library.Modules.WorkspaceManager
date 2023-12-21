namespace DockPanelSuite.Forms.Pages {

    partial class MainPage {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            ToolStrip = new ToolStrip();
            ToolStripLayouts = new ToolStripDropDownButton();
            StatusStrip = new StatusStrip();
            StatusStripLabel = new ToolStripStatusLabel();
            MenuStrip = new MenuStrip();
            MenuStripFile = new ToolStripMenuItem();
            MenuStripFileExit = new ToolStripMenuItem();
            MenuStripTheme = new ToolStripMenuItem();
            MenuStripThemeLight = new ToolStripMenuItem();
            MenuStripThemeDark = new ToolStripMenuItem();
            MenuStripWindow = new ToolStripMenuItem();
            MenuStripWindowLayouts = new ToolStripMenuItem();
            MenuStripWindowSeparator1 = new ToolStripSeparator();
            MenuStripWindowLeftPanel = new ToolStripMenuItem();
            MenuStripWindowRightPanel = new ToolStripMenuItem();
            MenuStripWindowBottomPanel = new ToolStripMenuItem();
            MenuStripWindowDocumentPanel = new ToolStripMenuItem();
            MenuStripWindowFloatPanel = new ToolStripMenuItem();
            DockPanel = new Panel();
            TopPanel = new Panel();
            ToolStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            MenuStrip.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ToolStrip
            // 
            ToolStrip.Dock = DockStyle.Right;
            ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip.ImageScalingSize = new Size(24, 24);
            ToolStrip.Items.AddRange(new ToolStripItem[] { ToolStripLayouts });
            ToolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            ToolStrip.Location = new Point(966, 0);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(92, 39);
            ToolStrip.TabIndex = 1;
            // 
            // ToolStripLayouts
            // 
            ToolStripLayouts.Alignment = ToolStripItemAlignment.Right;
            ToolStripLayouts.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripLayouts.Image = (Image)resources.GetObject("ToolStripLayouts.Image");
            ToolStripLayouts.ImageTransparentColor = Color.Magenta;
            ToolStripLayouts.Name = "ToolStripLayouts";
            ToolStripLayouts.Size = new Size(42, 34);
            // 
            // StatusStrip
            // 
            StatusStrip.ImageScalingSize = new Size(24, 24);
            StatusStrip.Items.AddRange(new ToolStripItem[] { StatusStripLabel });
            StatusStrip.Location = new Point(0, 632);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(1058, 32);
            StatusStrip.TabIndex = 2;
            StatusStrip.Text = "statusStrip1";
            // 
            // StatusStripLabel
            // 
            StatusStripLabel.Name = "StatusStripLabel";
            StatusStripLabel.Size = new Size(60, 25);
            StatusStripLabel.Text = "Status";
            // 
            // MenuStrip
            // 
            MenuStrip.Dock = DockStyle.Fill;
            MenuStrip.ImageScalingSize = new Size(24, 24);
            MenuStrip.Items.AddRange(new ToolStripItem[] { MenuStripFile, MenuStripTheme, MenuStripWindow });
            MenuStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(966, 39);
            MenuStrip.TabIndex = 3;
            // 
            // MenuStripFile
            // 
            MenuStripFile.DropDownItems.AddRange(new ToolStripItem[] { MenuStripFileExit });
            MenuStripFile.Name = "MenuStripFile";
            MenuStripFile.Size = new Size(54, 35);
            MenuStripFile.Text = "File";
            // 
            // MenuStripFileExit
            // 
            MenuStripFileExit.Name = "MenuStripFileExit";
            MenuStripFileExit.Size = new Size(141, 34);
            MenuStripFileExit.Text = "Exit";
            MenuStripFileExit.Click += MenuStripFileExit_Click;
            // 
            // MenuStripTheme
            // 
            MenuStripTheme.DropDownItems.AddRange(new ToolStripItem[] { MenuStripThemeLight, MenuStripThemeDark });
            MenuStripTheme.Name = "MenuStripTheme";
            MenuStripTheme.Size = new Size(81, 35);
            MenuStripTheme.Text = "Theme";
            // 
            // MenuStripThemeLight
            // 
            MenuStripThemeLight.Name = "MenuStripThemeLight";
            MenuStripThemeLight.Size = new Size(153, 34);
            MenuStripThemeLight.Text = "Light";
            MenuStripThemeLight.Click += MenuStripThemeLight_Click;
            // 
            // MenuStripThemeDark
            // 
            MenuStripThemeDark.Name = "MenuStripThemeDark";
            MenuStripThemeDark.Size = new Size(153, 34);
            MenuStripThemeDark.Text = "Dark";
            MenuStripThemeDark.Click += MenuStripThemeDark_Click;
            // 
            // MenuStripWindow
            // 
            MenuStripWindow.DropDownItems.AddRange(new ToolStripItem[] { MenuStripWindowLayouts, MenuStripWindowSeparator1, MenuStripWindowLeftPanel, MenuStripWindowRightPanel, MenuStripWindowBottomPanel, MenuStripWindowDocumentPanel, MenuStripWindowFloatPanel });
            MenuStripWindow.Name = "MenuStripWindow";
            MenuStripWindow.Size = new Size(94, 35);
            MenuStripWindow.Text = "Window";
            // 
            // MenuStripWindowLayouts
            // 
            MenuStripWindowLayouts.Name = "MenuStripWindowLayouts";
            MenuStripWindowLayouts.Size = new Size(243, 34);
            MenuStripWindowLayouts.Text = "Layouts";
            // 
            // MenuStripWindowSeparator1
            // 
            MenuStripWindowSeparator1.Name = "MenuStripWindowSeparator1";
            MenuStripWindowSeparator1.Size = new Size(240, 6);
            // 
            // MenuStripWindowLeftPanel
            // 
            MenuStripWindowLeftPanel.Name = "MenuStripWindowLeftPanel";
            MenuStripWindowLeftPanel.Size = new Size(243, 34);
            MenuStripWindowLeftPanel.Text = "Left Panel";
            MenuStripWindowLeftPanel.Click += MenuStripWindowLeftPanel_Click;
            // 
            // MenuStripWindowRightPanel
            // 
            MenuStripWindowRightPanel.Name = "MenuStripWindowRightPanel";
            MenuStripWindowRightPanel.Size = new Size(243, 34);
            MenuStripWindowRightPanel.Text = "Right Panel";
            MenuStripWindowRightPanel.Click += MenuStripWindowRightPanel_Click;
            // 
            // MenuStripWindowBottomPanel
            // 
            MenuStripWindowBottomPanel.Name = "MenuStripWindowBottomPanel";
            MenuStripWindowBottomPanel.Size = new Size(243, 34);
            MenuStripWindowBottomPanel.Text = "Bottom Panel";
            MenuStripWindowBottomPanel.Click += MenuStripWindowBottomPanel_Click;
            // 
            // MenuStripWindowDocumentPanel
            // 
            MenuStripWindowDocumentPanel.Name = "MenuStripWindowDocumentPanel";
            MenuStripWindowDocumentPanel.Size = new Size(243, 34);
            MenuStripWindowDocumentPanel.Text = "Document Panel";
            MenuStripWindowDocumentPanel.Click += MenuStripWindowDocumentPanel_Click;
            // 
            // MenuStripWindowFloatPanel
            // 
            MenuStripWindowFloatPanel.Name = "MenuStripWindowFloatPanel";
            MenuStripWindowFloatPanel.Size = new Size(243, 34);
            MenuStripWindowFloatPanel.Text = "Float Panel";
            MenuStripWindowFloatPanel.Click += MenuStripWindowFloatPanel_Click;
            // 
            // DockPanel
            // 
            DockPanel.Dock = DockStyle.Fill;
            DockPanel.Location = new Point(0, 39);
            DockPanel.Name = "DockPanel";
            DockPanel.Size = new Size(1058, 593);
            DockPanel.TabIndex = 4;
            // 
            // TopPanel
            // 
            TopPanel.Controls.Add(MenuStrip);
            TopPanel.Controls.Add(ToolStrip);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1058, 39);
            TopPanel.TabIndex = 0;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 664);
            Controls.Add(DockPanel);
            Controls.Add(TopPanel);
            Controls.Add(StatusStrip);
            MainMenuStrip = MenuStrip;
            MinimumSize = new Size(720, 480);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Form";
            FormClosing += DockForm_FormClosing;
            Load += DockForm_Load;
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip ToolStrip;
        private ToolStripDropDownButton ToolStripLayouts;
        private StatusStrip StatusStrip;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem MenuStripTheme;
        private ToolStripMenuItem MenuStripThemeLight;
        private ToolStripMenuItem MenuStripWindow;
        private Panel DockPanel;
        private ToolStripMenuItem MenuStripFile;
        private ToolStripMenuItem MenuStripFileExit;
        private ToolStripMenuItem MenuStripThemeDark;
        private ToolStripStatusLabel StatusStripLabel;
        private ToolStripMenuItem MenuStripWindowLayouts;
        private ToolStripSeparator MenuStripWindowSeparator1;
        private ToolStripMenuItem MenuStripWindowLeftPanel;
        private Panel TopPanel;
        private ToolStripMenuItem MenuStripWindowRightPanel;
        private ToolStripMenuItem MenuStripWindowBottomPanel;
        private ToolStripMenuItem MenuStripWindowDocumentPanel;
        private ToolStripMenuItem MenuStripWindowFloatPanel;
    }
}
