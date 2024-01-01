using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    internal class DefaultAutoHideStripFactory : DockPanelExtender.IAutoHideStripFactory {

        public AutoHideStripBase CreateAutoHideStrip(DockPanel panel) {
            return new DefaultAutoHideStrip(panel);
        }
    }
}