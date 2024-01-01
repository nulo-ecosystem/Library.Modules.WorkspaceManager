using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    public class DefaultDockPaneStripFactory : DockPanelExtender.IDockPaneStripFactory {

        public DockPaneStripBase CreateDockPaneStrip(DockPane pane) {
            return new DefaultDockPaneStrip(pane);
        }
    }
}