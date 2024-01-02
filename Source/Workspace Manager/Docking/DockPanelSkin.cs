using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Nulo.Modules.WorkspaceManager.Docking {

    #region DockPanelSkin classes

    /// <summary>
    /// The skin to use when displaying the DockPanel.
    /// The skin allows custom gradient color schemes to be used when drawing the
    /// DockStrips and Tabs.
    /// </summary>
    [TypeConverter(typeof(DockPanelSkinConverter))]
    public class DockPanelSkin {
        private AutoHideStripSkin m_autoHideStripSkin = new();
        private DockPaneStripSkin m_dockPaneStripSkin = new();

        /// <summary>
        /// The skin used to display the auto hide strips and tabs.
        /// </summary>
        public AutoHideStripSkin AutoHideStripSkin {
            get { return m_autoHideStripSkin; }
            set { m_autoHideStripSkin = value; }
        }

        /// <summary>
        /// The skin used to display the Document and ToolWindow style DockStrips and Tabs.
        /// </summary>
        public DockPaneStripSkin DockPaneStripSkin {
            get { return m_dockPaneStripSkin; }
            set { m_dockPaneStripSkin = value; }
        }
    }

    /// <summary>
    /// The skin used to display the auto hide strip and tabs.
    /// </summary>
    [TypeConverter(typeof(AutoHideStripConverter))]
    public class AutoHideStripSkin {
        private DockPanelGradient m_dockStripGradient = new();
        private TabGradient m_TabGradient = new();
        private DockStripBackground m_DockStripBackground = new();

        private Font m_textFont = SystemFonts.MenuFont;

        /// <summary>
        /// The gradient color skin for the DockStrips.
        /// </summary>
        public DockPanelGradient DockStripGradient {
            get { return m_dockStripGradient; }
            set { m_dockStripGradient = value; }
        }

        /// <summary>
        /// The gradient color skin for the Tabs.
        /// </summary>
        public TabGradient TabGradient {
            get { return m_TabGradient; }
            set { m_TabGradient = value; }
        }

        /// <summary>
        /// The gradient color skin for the Tabs.
        /// </summary>
        public DockStripBackground DockStripBackground {
            get { return m_DockStripBackground; }
            set { m_DockStripBackground = value; }
        }

        /// <summary>
        /// Font used in AutoHideStrip elements.
        /// </summary>
        [DefaultValue(typeof(SystemFonts), "MenuFont")]
        public Font TextFont {
            get { return m_textFont; }
            set { m_textFont = value; }
        }
    }

    /// <summary>
    /// The skin used to display the document and tool strips and tabs.
    /// </summary>
    [TypeConverter(typeof(DockPaneStripConverter))]
    public class DockPaneStripSkin {
        private DockPaneStripGradient m_DocumentGradient = new();
        private DockPaneStripToolWindowGradient m_ToolWindowGradient = new();
        private Font m_textFont = SystemFonts.MenuFont;

        /// <summary>
        /// The skin used to display the Document style DockPane strip and tab.
        /// </summary>
        public DockPaneStripGradient DocumentGradient {
            get { return m_DocumentGradient; }
            set { m_DocumentGradient = value; }
        }

        /// <summary>
        /// The skin used to display the ToolWindow style DockPane strip and tab.
        /// </summary>
        public DockPaneStripToolWindowGradient ToolWindowGradient {
            get { return m_ToolWindowGradient; }
            set { m_ToolWindowGradient = value; }
        }

        /// <summary>
        /// Font used in DockPaneStrip elements.
        /// </summary>
        [DefaultValue(typeof(SystemFonts), "MenuFont")]
        public Font TextFont {
            get { return m_textFont; }
            set { m_textFont = value; }
        }
    }

    /// <summary>
    /// The skin used to display the DockPane ToolWindow strip and tab.
    /// </summary>
    [TypeConverter(typeof(DockPaneStripGradientConverter))]
    public class DockPaneStripToolWindowGradient : DockPaneStripGradient {
        private TabGradient m_activeCaptionGradient = new();
        private TabGradient m_inactiveCaptionGradient = new();

        /// <summary>
        /// The skin used to display the active ToolWindow caption.
        /// </summary>
        public TabGradient ActiveCaptionGradient {
            get { return m_activeCaptionGradient; }
            set { m_activeCaptionGradient = value; }
        }

        /// <summary>
        /// The skin used to display the inactive ToolWindow caption.
        /// </summary>
        public TabGradient InactiveCaptionGradient {
            get { return m_inactiveCaptionGradient; }
            set { m_inactiveCaptionGradient = value; }
        }
    }

    /// <summary>
    /// The skin used to display the DockPane strip and tab.
    /// </summary>
    [TypeConverter(typeof(DockPaneStripGradientConverter))]
    public class DockPaneStripGradient {
        private DockPanelGradient m_dockStripGradient = new();
        private TabGradient m_activeTabGradient = new();
        private TabGradient m_inactiveTabGradient = new();
        private TabGradient m_hoverTabGradient = new();

        /// <summary>
        /// The gradient color skin for the DockStrip.
        /// </summary>
        public DockPanelGradient DockStripGradient {
            get { return m_dockStripGradient; }
            set { m_dockStripGradient = value; }
        }

        /// <summary>
        /// The skin used to display the active DockPane tabs.
        /// </summary>
        public TabGradient ActiveTabGradient {
            get { return m_activeTabGradient; }
            set { m_activeTabGradient = value; }
        }

        public TabGradient HoverTabGradient {
            get { return m_hoverTabGradient; }
            set { m_hoverTabGradient = value; }
        }

        /// <summary>
        /// The skin used to display the inactive DockPane tabs.
        /// </summary>
        public TabGradient InactiveTabGradient {
            get { return m_inactiveTabGradient; }
            set { m_inactiveTabGradient = value; }
        }
    }

    /// <summary>
    /// The skin used to display the dock pane tab
    /// </summary>
    [TypeConverter(typeof(DockPaneTabGradientConverter))]
    public class TabGradient : DockPanelGradient {
        private Color m_textColor = SystemColors.ControlText;

        /// <summary>
        /// The text color.
        /// </summary>
        [DefaultValue(typeof(SystemColors), "ControlText")]
        public Color TextColor {
            get { return m_textColor; }
            set { m_textColor = value; }
        }
    }

    /// <summary>
    /// The skin used to display the dock pane tab
    /// </summary>
    [TypeConverter(typeof(DockPaneTabGradientConverter))]
    public class DockStripBackground {
        private Color m_startColor = SystemColors.Control;
        private Color m_endColor = SystemColors.Control;
        //private LinearGradientMode m_linearGradientMode = LinearGradientMode.Horizontal;

        /// <summary>
        /// The beginning gradient color.
        /// </summary>
        [DefaultValue(typeof(SystemColors), "Control")]
        public Color StartColor {
            get { return m_startColor; }
            set { m_startColor = value; }
        }

        /// <summary>
        /// The ending gradient color.
        /// </summary>
        [DefaultValue(typeof(SystemColors), "Control")]
        public Color EndColor {
            get { return m_endColor; }
            set { m_endColor = value; }
        }
    }

    /// <summary>
    /// The gradient color skin.
    /// </summary>
    [TypeConverter(typeof(DockPanelGradientConverter))]
    public class DockPanelGradient {
        private Color m_startColor = SystemColors.Control;
        private Color m_endColor = SystemColors.Control;
        private LinearGradientMode m_linearGradientMode = LinearGradientMode.Horizontal;

        /// <summary>
        /// The beginning gradient color.
        /// </summary>
        [DefaultValue(typeof(SystemColors), "Control")]
        public Color StartColor {
            get { return m_startColor; }
            set { m_startColor = value; }
        }

        /// <summary>
        /// The ending gradient color.
        /// </summary>
        [DefaultValue(typeof(SystemColors), "Control")]
        public Color EndColor {
            get { return m_endColor; }
            set { m_endColor = value; }
        }

        /// <summary>
        /// The gradient mode to display the colors.
        /// </summary>
        [DefaultValue(LinearGradientMode.Horizontal)]
        public LinearGradientMode LinearGradientMode {
            get { return m_linearGradientMode; }
            set { m_linearGradientMode = value; }
        }
    }

    #endregion DockPanelSkin classes

    #region Converters

    public class DockPanelSkinConverter : ExpandableObjectConverter {

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            return destinationType == typeof(DockPanelSkin) || base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
            if(destinationType == typeof(string) && value is DockPanelSkin) { return "DockPanelSkin"; }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    public class DockPanelGradientConverter : ExpandableObjectConverter {

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            return destinationType == typeof(DockPanelGradient) || base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
            if(destinationType == typeof(string) && value is DockPanelGradient) { return "DockPanelGradient"; }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    public class AutoHideStripConverter : ExpandableObjectConverter {

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            return destinationType == typeof(AutoHideStripSkin) || base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
            if(destinationType == typeof(string) && value is AutoHideStripSkin) { return "AutoHideStripSkin"; }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    public class DockPaneStripConverter : ExpandableObjectConverter {

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            return destinationType == typeof(DockPaneStripSkin) || base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
            if(destinationType == typeof(string) && value is DockPaneStripSkin) { return "DockPaneStripSkin"; }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    public class DockPaneStripGradientConverter : ExpandableObjectConverter {

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            return destinationType == typeof(DockPaneStripGradient) || base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
            if(destinationType == typeof(string) && value is DockPaneStripGradient) { return "DockPaneStripGradient"; }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }

    public class DockPaneTabGradientConverter : ExpandableObjectConverter {

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) {
            return destinationType == typeof(TabGradient) || base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destinationType) {
            return destinationType == typeof(string) && value is TabGradient ? "DockPaneTabGradient" : base.ConvertTo(context, culture, value, destinationType);
        }
    }

    #endregion Converters
}