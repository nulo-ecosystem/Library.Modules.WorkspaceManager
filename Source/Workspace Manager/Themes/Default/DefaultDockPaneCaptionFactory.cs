using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    internal class DefaultDockPaneCaptionFactory : DockPanelExtender.IDockPaneCaptionFactory {

        public DockPaneCaptionBase CreateDockPaneCaption(DockPane pane) {
            return new DefaultDockPaneCaption(pane);
        }
    }
}