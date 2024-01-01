using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager {

    public interface IWorkspaceTheme {

        ThemeBase GetTheme(string key = null);
    }
}