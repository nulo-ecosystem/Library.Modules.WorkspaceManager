namespace Nulo.Modules.DockPanelSuite.LayoutManager {

    public class Layout(string name) {

        public string Name { get; private set; } = name;
        public string Key { get; private set; } = null;

        public Layout(string name, string key) : this(name) => Key = key;
    }
}