using Nulo.Modules.DockPanelSuite.Docking;
using System.Collections.Generic;

namespace Nulo.Modules.DockPanelSuite.WorkspaceManager {

    public interface IWorkspaceData {

        #region Current Workspace
        string LoadCurrentWorkspace();
        void SaveCurrentWorkspace(string content);
        #endregion

        #region Default Workspaces
        List<DefaultWorkspace> LoadAllDefaultWorkspaces();
        string LoadDefaultWorkspace(string key = null);
        #endregion

        #region User Workspaces
        List<string> LoadAllUserWorkspaces();
        string LoadUserWorkspace(string key = null);
        bool SaveUserWorkspace(UserWorkspace workspace);
        bool RemoveUserWorkspace(UserWorkspace workspace);
        #endregion

        IDockContent GetInstanceByPanelType(string fullName);
    }
}