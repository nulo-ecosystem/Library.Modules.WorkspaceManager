﻿using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    [ToolboxItem(false)]
    public class DefaultDockPane : DockPane {

        public DefaultDockPane(IDockContent content, DockState visibleState, bool show) : base(content, visibleState, show) { }

        public DefaultDockPane(IDockContent content, FloatWindow floatWindow, bool show) : base(content, floatWindow, show) { }

        public DefaultDockPane(IDockContent content, DockPane previousPane, DockAlignment alignment, double proportion, bool show) : base(content, previousPane, alignment, proportion, show) { }

        public DefaultDockPane(IDockContent content, Rectangle floatWindowBounds, bool show) : base(content, floatWindowBounds, show) { }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            var color = DockPanel.Theme.ColorPalette.ToolWindowBorder;
            e.Graphics.FillRectangle(DockPanel.Theme.PaintingService.GetBrush(color), e.ClipRectangle);
        }

        protected internal override Rectangle ContentRectangle {
            get {
                var rect = base.ContentRectangle;
                if(DockState == DockState.Document || Contents.Count == 1) {
                    rect.Height--;
                }

                rect.Width -= 2;
                rect.X++;
                return rect;
            }
        }
    }
}