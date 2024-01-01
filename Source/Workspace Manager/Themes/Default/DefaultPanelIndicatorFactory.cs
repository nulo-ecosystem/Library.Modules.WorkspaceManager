using Nulo.Modules.WorkspaceManager.Docking;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    internal class DefaultPanelIndicatorFactory : DockPanelExtender.IPanelIndicatorFactory {

        public DockPanel.IPanelIndicator CreatePanelIndicator(DockStyle style, ThemeBase theme) {
            return new DefaultPanelIndicator(style, theme);
        }

        [ToolboxItem(false)]
        private class DefaultPanelIndicator : PictureBox, DockPanel.IPanelIndicator {
            private readonly Image _imagePanelLeft;
            private readonly Image _imagePanelRight;
            private readonly Image _imagePanelTop;
            private readonly Image _imagePanelBottom;
            private readonly Image _imagePanelFill;
            private readonly Image _imagePanelLeftActive;
            private readonly Image _imagePanelRightActive;
            private readonly Image _imagePanelTopActive;
            private readonly Image _imagePanelBottomActive;
            private readonly Image _imagePanelFillActive;

            public DefaultPanelIndicator(DockStyle dockStyle, ThemeBase theme) {
                _imagePanelLeft = theme.ImageService.DockIndicator_PanelLeft;
                _imagePanelRight = theme.ImageService.DockIndicator_PanelRight;
                _imagePanelTop = theme.ImageService.DockIndicator_PanelTop;
                _imagePanelBottom = theme.ImageService.DockIndicator_PanelBottom;
                _imagePanelFill = theme.ImageService.DockIndicator_PanelFill;
                _imagePanelLeftActive = theme.ImageService.DockIndicator_PanelLeft;
                _imagePanelRightActive = theme.ImageService.DockIndicator_PanelRight;
                _imagePanelTopActive = theme.ImageService.DockIndicator_PanelTop;
                _imagePanelBottomActive = theme.ImageService.DockIndicator_PanelBottom;
                _imagePanelFillActive = theme.ImageService.DockIndicator_PanelFill;

                m_dockStyle = dockStyle;
                SizeMode = PictureBoxSizeMode.AutoSize;
                Image = ImageInactive;
            }

            private DockStyle m_dockStyle;

            private DockStyle DockStyle {
                get { return m_dockStyle; }
            }

            private DockStyle m_status;

            public DockStyle Status {
                get { return m_status; }
                set {
                    if(value != DockStyle && value != DockStyle.None) { throw new InvalidEnumArgumentException(); }
                    if(m_status == value) { return; }

                    m_status = value;
                    IsActivated = (m_status != DockStyle.None);
                }
            }

            private Image ImageInactive {
                get {
                    if(DockStyle == DockStyle.Left) {
                        return _imagePanelLeft;
                    } else if(DockStyle == DockStyle.Right) {
                        return _imagePanelRight;
                    } else if(DockStyle == DockStyle.Top) {
                        return _imagePanelTop;
                    } else if(DockStyle == DockStyle.Bottom) {
                        return _imagePanelBottom;
                    } else if(DockStyle == DockStyle.Fill) {
                        return _imagePanelFill;
                    } else {
                        return null;
                    }
                }
            }

            private Image ImageActive {
                get {
                    if(DockStyle == DockStyle.Left) {
                        return _imagePanelLeftActive;
                    } else if(DockStyle == DockStyle.Right) {
                        return _imagePanelRightActive;
                    } else if(DockStyle == DockStyle.Top) {
                        return _imagePanelTopActive;
                    } else if(DockStyle == DockStyle.Bottom) {
                        return _imagePanelBottomActive;
                    } else if(DockStyle == DockStyle.Fill) {
                        return _imagePanelFillActive;
                    } else {
                        return null;
                    }
                }
            }

            private bool m_isActivated = false;

            private bool IsActivated {
                get { return m_isActivated; }
                set {
                    m_isActivated = value;
                    Image = IsActivated ? ImageActive : ImageInactive;
                }
            }

            public DockStyle HitTest(Point pt) {
                return Visible && ClientRectangle.Contains(PointToClient(pt)) ? DockStyle : DockStyle.None;
            }
        }
    }
}