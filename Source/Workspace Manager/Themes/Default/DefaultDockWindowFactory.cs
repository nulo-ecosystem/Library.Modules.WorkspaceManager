using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    internal class DefaultDockWindowFactory : DockPanelExtender.IDockWindowFactory {

        public DockWindow CreateDockWindow(DockPanel dockPanel, DockState dockState) {
            return new DefaultDockWindow(dockPanel, dockState);
        }
    }
}