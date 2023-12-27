using Nulo.Modules.DockPanelSuite.Docking;
using Nulo.Modules.DockPanelSuite.WorkspaceManager;

namespace DockPanelSuite.Forms.Modules.WorkspaceManager {

    public class WorkspaceData : IWorkspaceData {

        #region Current Workspace
        public string LoadCurrentWorkspace() {
            return Properties.Settings.Default.Workspace;
        }
        public void SaveCurrentWorkspace(string content) {
            Properties.Settings.Default.Workspace = content;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Default Workspaces
        public List<DefaultWorkspace> LoadAllDefaultWorkspaces() => [
            new DefaultWorkspace("Default", nameof(DefaultWorkspaces.Default)),
            new DefaultWorkspace("4 Split", nameof(DefaultWorkspaces.FourSplit)),
            new DefaultWorkspace("Empty", nameof(DefaultWorkspaces.Empty))
        ];
        public string LoadDefaultWorkspace(string key = null) {
            switch(key) {
                case nameof(DefaultWorkspaces.Default): { return DefaultWorkspaces.Default; }
                case nameof(DefaultWorkspaces.FourSplit): { return DefaultWorkspaces.FourSplit; }
                default: { return DefaultWorkspaces.Empty; }
            }
        }
        #endregion

        #region User Workspaces
        public List<string> LoadAllUserWorkspaces() {
            var userWorkspaces = Properties.Settings.Default.UserWorkspaces;

            if(userWorkspaces is null) {
                userWorkspaces = [];
                Properties.Settings.Default.UserWorkspaces = userWorkspaces;
                Properties.Settings.Default.Save();
            }

            List<string> list = [];
            foreach(var workspace in userWorkspaces) { list.Add(workspace.Key); }
            return list;
        }
        public string LoadUserWorkspace(string key = null) {
            var userWorkspaces = Properties.Settings.Default.UserWorkspaces;
            foreach(var workspace in userWorkspaces) {
                if(workspace.Key.Equals(key)) {
                    return workspace.Content;
                }
            }

            return null;
        }

        public bool SaveUserWorkspace(UserWorkspace workspace) {
            try {
                var userWorkspaces = Properties.Settings.Default.UserWorkspaces;
                userWorkspaces.Add(workspace);
                Properties.Settings.Default.UserWorkspaces = userWorkspaces;
                Properties.Settings.Default.Save();
                return true;
            } catch {
                return false;
            }
        }
        public bool RemoveUserWorkspace(UserWorkspace workspace) {
            var userWorkspaces = Properties.Settings.Default.UserWorkspaces;
            foreach(var _workspace in userWorkspaces) {
                if(_workspace.Key.Equals(workspace.Key)) {
                    userWorkspaces.Remove(_workspace);
                    Properties.Settings.Default.UserWorkspaces = userWorkspaces;
                    Properties.Settings.Default.Save();
                    return true;
                }
            }
            return false;
        }
        #endregion

        public IDockContent GetInstanceByPanelType(string fullName) {
            try {
                return Activator.CreateInstance(Type.GetType(fullName)) as IDockContent;
            } catch {
                return null;
            }
        }
    }
}