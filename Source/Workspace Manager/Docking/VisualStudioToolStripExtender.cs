using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Nulo.Modules.WorkspaceManager.Docking {

    [ProvideProperty("EnableVSStyle", typeof(ToolStrip))]
    public partial class ToolStripExtender : Component, IExtenderProvider {
        private readonly ThemeBase theme;
        private readonly Dictionary<ToolStrip, ToolStripProperties> strips = [];

        public ToolStripRenderer DefaultRenderer { get; set; }

        public ToolStripExtender(ThemeBase theme) {
            InitializeComponent();
            this.theme = theme;
        }

        public void SetStyle(ToolStrip strip) {
            ToolStripProperties properties;
            if(!strips.TryGetValue(strip, out ToolStripProperties value)) {
                properties = new ToolStripProperties(strip);
                strips.Add(strip, properties);
            } else {
                _ = value;
            }
            if(theme == null) {
                if(DefaultRenderer != null) { strip.Renderer = DefaultRenderer; }
            } else {
                theme.ApplyTo(strip);
            }
        }

        public bool CanExtend(object extendee) {
            return extendee is ToolStrip;
        }

        private class ToolStripProperties {
            private readonly ToolStrip strip;
            private readonly Dictionary<ToolStripItem, string> menuText = [];

            public ToolStripProperties(ToolStrip toolstrip) {
                strip = toolstrip ?? throw new ArgumentNullException(nameof(toolstrip));
                if(strip is MenuStrip) { SaveMenuStripText(); }
            }

            private void SaveMenuStripText() {
                foreach(ToolStripItem item in strip.Items) {
                    menuText.Add(item, item.Text);
                }
            }
        }
    }
}