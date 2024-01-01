using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    internal class DefaultAutoHideWindowFactory : DockPanelExtender.IAutoHideWindowFactory {

        public DockPanel.AutoHideWindowControl CreateAutoHideWindow(DockPanel panel) {
            return new DefaultAutoHideWindowControl(panel);
        }
    }
}