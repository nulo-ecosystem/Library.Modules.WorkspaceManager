using System.Drawing;
using System.Windows.Forms;

namespace Nulo.Pages {

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
            ToolStripWorkspaces = new ToolStripDropDownButton();
            StatusStrip = new StatusStrip();
            StatusStripLabel = new ToolStripStatusLabel();
            MenuStrip = new MenuStrip();
            MenuStripFile = new ToolStripMenuItem();
            MenuStripFileExit = new ToolStripMenuItem();
            MenuStripTheme = new ToolStripMenuItem();
            MenuStripThemeLight = new ToolStripMenuItem();
            MenuStripThemeDark = new ToolStripMenuItem();
            MenuStripWindow = new ToolStripMenuItem();
            MenuStripWindowWorkspaces = new ToolStripMenuItem();
            MenuStripWindowSeparator1 = new ToolStripSeparator();
            MenuStripWindowLeftPanel = new ToolStripMenuItem();
            MenuStripWindowRightPanel = new ToolStripMenuItem();
            MenuStripWindowBottomPanel = new ToolStripMenuItem();
            MenuStripWindowDocumentPanel = new ToolStripMenuItem();
            MenuStripWindowSeparator2 = new ToolStripSeparator();
            MenuStripWindowFloatPanel = new ToolStripMenuItem();
            DockPanel = new Panel();
            TopPanel = new Panel();
            MenuStripFileUpdate = new ToolStripMenuItem();
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
            ToolStrip.Items.AddRange(new ToolStripItem[] { ToolStripWorkspaces });
            ToolStrip.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            ToolStrip.Location = new Point(1012, 0);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(46, 39);
            ToolStrip.TabIndex = 1;
            // 
            // ToolStripWorkspaces
            // 
            ToolStripWorkspaces.Alignment = ToolStripItemAlignment.Right;
            ToolStripWorkspaces.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ToolStripWorkspaces.Image = (Image)resources.GetObject("ToolStripWorkspaces.Image");
            ToolStripWorkspaces.ImageTransparentColor = Color.Magenta;
            ToolStripWorkspaces.Name = "ToolStripWorkspaces";
            ToolStripWorkspaces.Size = new Size(42, 34);
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
            MenuStrip.Size = new Size(1012, 39);
            MenuStrip.TabIndex = 3;
            // 
            // MenuStripFile
            // 
            MenuStripFile.DropDownItems.AddRange(new ToolStripItem[] { MenuStripFileUpdate, MenuStripFileExit });
            MenuStripFile.Name = "MenuStripFile";
            MenuStripFile.Size = new Size(54, 35);
            MenuStripFile.Text = "File";
            // 
            // MenuStripFileExit
            // 
            MenuStripFileExit.Name = "MenuStripFileExit";
            MenuStripFileExit.Size = new Size(270, 34);
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
            MenuStripWindow.DropDownItems.AddRange(new ToolStripItem[] { MenuStripWindowWorkspaces, MenuStripWindowSeparator1, MenuStripWindowLeftPanel, MenuStripWindowRightPanel, MenuStripWindowBottomPanel, MenuStripWindowDocumentPanel, MenuStripWindowSeparator2, MenuStripWindowFloatPanel });
            MenuStripWindow.Name = "MenuStripWindow";
            MenuStripWindow.Size = new Size(94, 35);
            MenuStripWindow.Text = "Window";
            // 
            // MenuStripWindowWorkspaces
            // 
            MenuStripWindowWorkspaces.Name = "MenuStripWindowWorkspaces";
            MenuStripWindowWorkspaces.Size = new Size(243, 34);
            MenuStripWindowWorkspaces.Text = "Workspaces";
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
            // MenuStripWindowSeparator2
            // 
            MenuStripWindowSeparator2.Name = "MenuStripWindowSeparator2";
            MenuStripWindowSeparator2.Size = new Size(240, 6);
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
            // MenuStripFileUpdate
            // 
            MenuStripFileUpdate.Name = "MenuStripFileUpdate";
            MenuStripFileUpdate.Size = new Size(270, 34);
            MenuStripFileUpdate.Text = "Update";
            MenuStripFileUpdate.Click += MenuStripFileUpdate_Click;
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
            FormClosing += MainPage_FormClosing;
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
        private ToolStripDropDownButton ToolStripWorkspaces;
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
        private ToolStripMenuItem MenuStripWindowWorkspaces;
        private ToolStripSeparator MenuStripWindowSeparator1;
        private ToolStripMenuItem MenuStripWindowLeftPanel;
        private Panel TopPanel;
        private ToolStripMenuItem MenuStripWindowRightPanel;
        private ToolStripMenuItem MenuStripWindowBottomPanel;
        private ToolStripMenuItem MenuStripWindowDocumentPanel;
        private ToolStripMenuItem MenuStripWindowFloatPanel;
        private ToolStripSeparator MenuStripWindowSeparator2;
        private ToolStripMenuItem MenuStripFileUpdate;
    }
}
