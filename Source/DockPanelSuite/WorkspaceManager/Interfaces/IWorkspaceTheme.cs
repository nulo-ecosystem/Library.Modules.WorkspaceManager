using Nulo.Modules.DockPanelSuite.Docking;

namespace Nulo.Modules.WorkspaceManager {

    public interface IWorkspaceTheme {

        ThemeBase GetTheme(string key = null);
    }
}