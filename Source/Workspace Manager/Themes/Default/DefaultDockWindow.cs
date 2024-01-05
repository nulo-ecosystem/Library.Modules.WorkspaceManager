namespace Nulo.Modules.WorkspaceManager.Docking {

    /// <summary>
    /// Dock window of Visual Studio 2012 Light theme.
    /// </summary>
    /// <remarks>
    /// Initializes a new instance of the <see cref="VS2012DockWindow"/> class.
    /// </remarks>
    /// <param name="dockPanel">The dock panel.</param>
    /// <param name="dockState">State of the dock.</param>
    [ToolboxItem(false)]
    internal class DefaultDockWindow(DockPanel dockPanel, DockState dockState) : DockWindow(dockPanel, dockState) {
        public override Rectangle DisplayingRectangle {
            get {
                Rectangle rect = ClientRectangle;
                if(DockState == DockState.DockLeft) {
                    rect.Width -= DockPanel.Theme.Measures.SplitterSize;
                } else if(DockState == DockState.DockRight) {
                    rect.X += DockPanel.Theme.Measures.SplitterSize;
                    rect.Width -= DockPanel.Theme.Measures.SplitterSize;
                } else if(DockState == DockState.DockTop) {
                    rect.Height -= DockPanel.Theme.Measures.SplitterSize;
                } else if(DockState == DockState.DockBottom) {
                    rect.Y += DockPanel.Theme.Measures.SplitterSize;
                    rect.Height -= DockPanel.Theme.Measures.SplitterSize;
                }

                return rect;
            }
        }
    }
}