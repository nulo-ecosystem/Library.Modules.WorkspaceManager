using Nulo.Modules.WorkspaceManager.Docking;
using System.Collections.Generic;

namespace Nulo.Modules.WorkspaceManager {

    public interface IWorkspaceData {

        #region Current Workspace

        string LoadCurrentWorkspace();

        void SaveCurrentWorkspace(string content);

        #endregion Current Workspace

        #region Default Workspaces

        List<DefaultWorkspace> LoadAllDefaultWorkspaces();

        string LoadDefaultWorkspace(string key = null);

        #endregion Default Workspaces

        #region User Workspaces

        List<string> LoadAllUserWorkspaces();

        string LoadUserWorkspace(string key = null);

        bool SaveUserWorkspace(UserWorkspace workspace);

        bool DeleteUserWorkspace(UserWorkspace workspace);

        #endregion User Workspaces

        Texts GetTexts();

        IDockContent GetInstanceByPanelType(string fullName);
    }
}