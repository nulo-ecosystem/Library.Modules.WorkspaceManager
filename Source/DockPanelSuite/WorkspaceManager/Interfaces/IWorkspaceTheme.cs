using Nulo.Modules.DockPanelSuite.Docking;

namespace Nulo.Modules.DockPanelSuite.WorkspaceManager {

    public interface IWorkspaceTheme {

        ThemeBase GetTheme(string key = null);
    }
}