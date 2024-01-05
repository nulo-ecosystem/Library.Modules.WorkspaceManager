namespace Nulo.Modules.WorkspaceManager.Docking {

    internal static class ResourceHelper {
        private static ResourceManager _resourceManager = null;

        private static ResourceManager ResourceManager {
            get {
                _resourceManager ??= new ResourceManager("Nulo.Modules.WorkspaceManager.Docking.Strings", typeof(ResourceHelper).Assembly);
                return _resourceManager;
            }
        }

        public static string GetString(string name) {
            return ResourceManager.GetString(name);
        }
    }
}