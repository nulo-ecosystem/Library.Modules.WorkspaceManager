using Nulo.Modules.WorkspaceManager.Docking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Nulo.Modules.WorkspaceManager {

    public class WorkspaceManager<TWorkspaceTheme, TWorkspaceData> : IDisposable where TWorkspaceTheme : IWorkspaceTheme where TWorkspaceData : IWorkspaceData {
        private readonly IWorkspaceData workspaceData;
        private readonly IWorkspaceTheme workspaceTheme;

        public DockPanel DockPanel { get; private set; } = new DockPanel { Dock = DockStyle.Fill };

        #region Initialization

        public WorkspaceManager() {
            workspaceData = Activator.CreateInstance<TWorkspaceData>();
            workspaceTheme = Activator.CreateInstance<TWorkspaceTheme>();
            SetTheme(null);
        }

        public void Init() {
            // Set style
            if(Theme != null) { Style?.Invoke(new ToolStripExtender(Theme)); }

            // Set workspace
            if(workspaceData.LoadCurrentWorkspace() is string workspace && !string.IsNullOrEmpty(workspace)) {
                SetWorkspace(workspace);
            } else if(defaultWorkspaces != null && defaultWorkspaces.Count != 0) {
                SetWorkspace(workspaceData.LoadDefaultWorkspace(defaultWorkspaces[0].Key));
            }
        }

        #endregion Initialization

        #region Theme

        public ThemeBase Theme { get; private set; }
        public StyleHandler Style { get; set; }

        public void SetTheme(string key) {
            if(workspaceTheme.GetTheme(key) is not ThemeBase theme) { return; }
            if(key is null) {
                DockPanel.Theme = Theme = theme;
                Style?.Invoke(new ToolStripExtender(Theme));
            } else {
                var xmlContent = DockPanel.GenerateXml();

                // Update panels
                while(DockPanel.Contents.Count != 0) {
                    var content = (DockContent)DockPanel.Contents[0];
                    content.DockPanel = null;
                    currentPanels.Add(content);
                }
                // Update floats
                foreach(var window in DockPanel.FloatWindows.ToList()) { window.Dispose(); }

                DockPanel.Theme = Theme = theme;
                Style?.Invoke(new ToolStripExtender(Theme));
                if(currentPage != null) {
                    currentPage.SetStyle(new ToolStripExtender(Theme));
                    currentPage.SetColors(Theme.DockContentColorPalette);
                    currentPage.UpdateContent();
                }

                DockPanel.LoadFromXml(xmlContent, GetInstanceByPanelType);

                UpdateWorkspace();
            }
        }

        #endregion Theme

        #region Workspaces Manager

        private List<IDockContent> currentPanels;
        private List<string> userWorkspaces;
        private List<DefaultWorkspace> defaultWorkspaces;

        private void SetWorkspace(string xmlContent) {
            if(xmlContent != null && !string.IsNullOrEmpty(xmlContent)) {
                while(DockPanel.Contents.Count != 0) {
                    var content = (DockContent)DockPanel.Contents[0];
                    content.DockPanel = null;
                    currentPanels.Add(content);
                }

                DockPanel.LoadFromXml(xmlContent, GetInstanceByPanelType);

                if(currentPanels != null) {
                    while(currentPanels.Count != 0) {
                        ((DockContent)currentPanels[0]).Close();
                        currentPanels.RemoveAt(0);
                    }
                }
            }
        }

        public IDockContent GetInstanceByPanelType(string fullName) {
            if(currentPanels != null) {
                for(int i = 0; i < currentPanels.Count; i++) {
                    var currentPanel = currentPanels[i];
                    if(currentPanel.GetType().FullName.Equals(fullName)) {
                        currentPanels.RemoveAt(i);
                        return currentPanel;
                    }
                }
            }

            if(workspaceData.GetInstanceByPanelType(fullName) is IDockContent newPanel) {
                newPanel.UpdateContent();
                return newPanel;
            }

            return null;
        }

        private void SelectedItem_Click(object sender, EventArgs e) {
            if(sender is ToolStripMenuItem item) {
                string content = item.Tag != null && item.Tag is DefaultWorkspace workspace ? workspaceData.LoadDefaultWorkspace(workspace.Key) : workspaceData.LoadUserWorkspace(item.Text);
                if(!string.IsNullOrEmpty(content)) { SetWorkspace(content); }
            }
        }

        private void ItemNewWorkspace_Click(object sender, EventArgs e) {
            using var dialog = new NewWorkspaceDialog(userWorkspaces, defaultWorkspaces, texts);
            if(dialog.ShowDialog() == DialogResult.OK && workspaceData.SaveUserWorkspace(new UserWorkspace { Key = dialog.WorkspaceName, Content = DockPanel.GenerateXml() })) {
                userWorkspaces.Add(dialog.WorkspaceName);
            }
        }

        private void ItemDeleteWorkspace_Click(object sender, EventArgs e) {
            using var dialog = new DeleteWorkspaceDialog(userWorkspaces, texts);
            if(dialog.ShowDialog() == DialogResult.OK && workspaceData.DeleteUserWorkspace(new UserWorkspace { Key = userWorkspaces[dialog.IndexWorkspace] })) {
                userWorkspaces.RemoveAt(dialog.IndexWorkspace);
            }
        }

        public void UpdateWorkspace() {
            foreach(var panel in DockPanel.Contents) { panel.UpdateContent(); }
        }

        #endregion Workspaces Manager

        #region Options Manager

        private ToolStripMenuItem menuItemSaveWorkspace;
        private ToolStripMenuItem menuItemDeleteWorkspace;

        private ToolStripDropDownButton toolStripWorkspaces;

        public void SetToolStripWorkspaces(ToolStripDropDownButton toolStripWorkspaces) {
            this.toolStripWorkspaces = toolStripWorkspaces;

            defaultWorkspaces ??= workspaceData.LoadAllDefaultWorkspaces();
            userWorkspaces ??= workspaceData.LoadAllUserWorkspaces();
            currentPanels ??= [];

            if(menuItemSaveWorkspace is null) {
                menuItemSaveWorkspace = new ToolStripMenuItem();
                menuItemSaveWorkspace.Click += ItemNewWorkspace_Click;
            }
            if(menuItemDeleteWorkspace is null) {
                menuItemDeleteWorkspace = new ToolStripMenuItem();
                menuItemDeleteWorkspace.Click += ItemDeleteWorkspace_Click;
            }

            this.toolStripWorkspaces.DropDownOpening += ToolStripWorksoaces_DropDownOpening;
        }

        private void ToolStripWorksoaces_DropDownOpening(object sender, EventArgs e) {
            var dropDown = (ToolStripDropDownButton)sender;
            for(int i = 0; i < dropDown.DropDownItems.Count; i++) {
                if(dropDown.DropDownItems[i] is not ToolStripMenuItem) { continue; }
                dropDown.DropDownItems[i].Click -= SelectedItem_Click;
            }
            dropDown.DropDownItems.Clear();

            if(userWorkspaces.Count != 0) {
                for(int i = userWorkspaces.Count - 1; i > -1; i--) {
                    var item = new ToolStripMenuItem(userWorkspaces[i]);
                    item.Click += SelectedItem_Click;
                    dropDown.DropDownItems.Add(item);
                }
                dropDown.DropDownItems.Add(new ToolStripSeparator());
            }

            if(defaultWorkspaces.Count != 0) {
                foreach(var workspace in defaultWorkspaces) {
                    var item = new ToolStripMenuItem(workspace.Name) { Tag = workspace };
                    item.Click += SelectedItem_Click;
                    dropDown.DropDownItems.Add(item);
                }
                dropDown.DropDownItems.Add(new ToolStripSeparator());
            }

            dropDown.DropDownItems.Add(menuItemSaveWorkspace);
            if(userWorkspaces.Count != 0) { dropDown.DropDownItems.Add(menuItemDeleteWorkspace); }
        }

        private ToolStripMenuItem menuStripWindow;
        private ToolStripMenuItem menuStripWindowWorkspaces;

        public void SetMenuStripWorkspaces(ToolStripMenuItem menuStripWindow, ToolStripMenuItem menuStripWindowWorkspaces) {
            this.menuStripWindow = menuStripWindow;
            this.menuStripWindowWorkspaces = menuStripWindowWorkspaces;

            defaultWorkspaces ??= workspaceData.LoadAllDefaultWorkspaces();
            userWorkspaces ??= workspaceData.LoadAllUserWorkspaces();
            currentPanels ??= [];

            if(menuItemSaveWorkspace is null) {
                menuItemSaveWorkspace = new ToolStripMenuItem();
                menuItemSaveWorkspace.Click += ItemNewWorkspace_Click;
            }
            if(menuItemDeleteWorkspace is null) {
                menuItemDeleteWorkspace = new ToolStripMenuItem();
                menuItemDeleteWorkspace.Click += ItemDeleteWorkspace_Click;
            }

            this.menuStripWindow.DropDownOpening += MenuStripWorkspaces_DropDownOpening;
        }

        private void MenuStripWorkspaces_DropDownOpening(object sender, EventArgs e) {
            if(menuStripWindowWorkspaces is null) { return; }
            for(int i = 0; i < menuStripWindowWorkspaces.DropDownItems.Count; i++) {
                if(menuStripWindowWorkspaces.DropDownItems[i] is not ToolStripMenuItem) { continue; }
                menuStripWindowWorkspaces.DropDownItems[i].Click -= SelectedItem_Click;
            }
            menuStripWindowWorkspaces.DropDownItems.Clear();

            if(userWorkspaces.Count != 0) {
                for(int i = userWorkspaces.Count - 1; i > -1; i--) {
                    var item = new ToolStripMenuItem(userWorkspaces[i]);
                    item.Click += SelectedItem_Click;
                    menuStripWindowWorkspaces.DropDownItems.Add(item);
                }
                menuStripWindowWorkspaces.DropDownItems.Add(new ToolStripSeparator());
            }

            if(defaultWorkspaces.Count != 0) {
                foreach(var workspace in defaultWorkspaces) {
                    var item = new ToolStripMenuItem(workspace.Name) { Tag = workspace };
                    item.Click += SelectedItem_Click;
                    menuStripWindowWorkspaces.DropDownItems.Add(item);
                }
                menuStripWindowWorkspaces.DropDownItems.Add(new ToolStripSeparator());
            }

            menuStripWindowWorkspaces.DropDownItems.Add(menuItemSaveWorkspace);
            if(userWorkspaces.Count != 0) { menuStripWindowWorkspaces.DropDownItems.Add(menuItemDeleteWorkspace); }
        }

        #endregion Options Manager

        #region Panels Manager

        private DockContent currentPage;

        public void OpenPage<T>() where T : DockContent {
            using var page = Activator.CreateInstance<T>();
            page.SetColors(DockPanel.Theme.DockContentColorPalette);
            page.SetStyle(new ToolStripExtender(DockPanel.Theme));
            page.Update();
            currentPage = page;
            page.ShowDialog();
        }

        public T OpenDialog<T>() where T : DockContent {
            var dialog = Activator.CreateInstance<T>();
            dialog.SetColors(DockPanel.Theme.DockContentColorPalette);
            return dialog;
        }

        public T OpenPanel<T>() where T : DockContent {
            if(GetPanelByType<T>() is T panel) {
                panel.Activate();
                panel.UpdateContent();
            } else {
                panel = Activator.CreateInstance<T>();
                panel.SetColors(DockPanel.Theme.DockContentColorPalette);
                panel.SetStyle(new ToolStripExtender(DockPanel.Theme));
                panel.UpdateContent();
                panel.Show(DockPanel);
            }

            return panel;
        }

        public DockContent GetPanelByType<T>() where T : DockContent {
            foreach(DockContent content in DockPanel.Contents.Cast<DockContent>()) {
                if(content.Name.Equals(typeof(T).Name)) {
                    return content;
                }
            }
            return null;
        }

        #endregion Panels Manager

        #region Texts Manager

        private Texts texts = new();

        public void UpdateTexts() {
            if(workspaceData.GetTexts() is Texts texts) {
                this.texts = texts;
                if(menuItemSaveWorkspace is not null) {
                    menuItemSaveWorkspace.Text = this.texts.SaveMenuItem;
                    menuItemDeleteWorkspace.Text = this.texts.DeleteMenuItem;
                }
            }
        }

        #endregion Texts Manager

        public virtual void Dispose() {
            if(toolStripWorkspaces is not null) { toolStripWorkspaces.DropDownOpening -= ToolStripWorksoaces_DropDownOpening; }
            if(menuStripWindow is not null) { menuStripWindow.DropDownOpening -= MenuStripWorkspaces_DropDownOpening; }
            workspaceData.SaveCurrentWorkspace(DockPanel.GenerateXml());
            GC.SuppressFinalize(this);
        }
    }
}