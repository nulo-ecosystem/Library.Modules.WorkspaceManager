namespace Nulo.Modules.WorkspaceManager {

    public class DefaultWorkspace(string name, string key) {

        public string Key { get; private set; } = key;
        public string Name { get; private set; } = name;
    }
}