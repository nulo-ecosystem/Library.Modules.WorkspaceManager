using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    internal class DefaultDockPaneSplitterControlFactory : DockPanelExtender.IDockPaneSplitterControlFactory {

        public DockPane.SplitterControlBase CreateSplitterControl(DockPane pane) {
            return new DefaultSplitterControl(pane);
        }
    }
}