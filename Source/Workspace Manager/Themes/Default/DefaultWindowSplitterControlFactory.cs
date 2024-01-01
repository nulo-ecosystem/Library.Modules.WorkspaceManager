using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    internal class DefaultWindowSplitterControlFactory : DockPanelExtender.IWindowSplitterControlFactory {

        public SplitterBase CreateSplitterControl(ISplitterHost host) {
            return new DefaultWindowSplitterControl(host);
        }
    }
}