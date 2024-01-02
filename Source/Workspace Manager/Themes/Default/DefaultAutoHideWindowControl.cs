using System.Drawing;
using System.Windows.Forms;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    using Docking;
    using System.ComponentModel;

    [ToolboxItem(false)]
    internal class DefaultAutoHideWindowControl(DockPanel dockPanel) : DockPanel.AutoHideWindowControl(dockPanel) {

        protected override Rectangle DisplayingRectangle {
            get {
                Rectangle rect = ClientRectangle;

                // exclude the border and the splitter
                if(DockState == DockState.DockBottomAutoHide) {
                    rect.Y += DockPanel.Theme.Measures.AutoHideSplitterSize;
                    rect.Height -= DockPanel.Theme.Measures.AutoHideSplitterSize;
                } else if(DockState == DockState.DockRightAutoHide) {
                    rect.X += DockPanel.Theme.Measures.AutoHideSplitterSize;
                    rect.Width -= DockPanel.Theme.Measures.AutoHideSplitterSize;
                } else if(DockState == DockState.DockTopAutoHide) {
                    rect.Height -= DockPanel.Theme.Measures.AutoHideSplitterSize;
                } else if(DockState == DockState.DockLeftAutoHide) {
                    rect.Width -= DockPanel.Theme.Measures.AutoHideSplitterSize;
                }

                return rect;
            }
        }

        protected override void OnLayout(LayoutEventArgs levent) {
            DockPadding.All = 0;
            if(DockState == DockState.DockLeftAutoHide) {
                MSplitter.Dock = DockStyle.Right;
            } else if(DockState == DockState.DockRightAutoHide) {
                MSplitter.Dock = DockStyle.Left;
            } else if(DockState == DockState.DockTopAutoHide) {
                MSplitter.Dock = DockStyle.Bottom;
            } else if(DockState == DockState.DockBottomAutoHide) {
                MSplitter.Dock = DockStyle.Top;
            }

            Rectangle rectDisplaying = DisplayingRectangle;
            Rectangle rectHidden = new(-rectDisplaying.Width, rectDisplaying.Y, rectDisplaying.Width, rectDisplaying.Height);
            foreach(Control c in Controls) {
                if(c is not DockPane pane) { continue; }

                if(pane == ActivePane) {
                    pane.Bounds = rectDisplaying;
                } else {
                    pane.Bounds = rectHidden;
                }
            }

            base.OnLayout(levent);
        }
    }
}