using Nulo.Modules.DockPanelSuite.Docking;
using System.Collections.Generic;

namespace Nulo.Modules.DockPanelSuite.LayoutManager {

    public interface ILayoutData {

        string LoadCurrentLayout();
        void SaveCurrentLayout(string content);

        List<Layout> LoadAllDefaultLayouts();
        string LoadDefaultLayout(string key);

        List<string> LoadAllUserLayouts();
        string LoadUserLayout(string key);
        bool SaveUserLayout(string key, string xmlContent);
        bool RemoveUserLayout(string key);

        IDockContent GetInstanceByPersistString(string persistString);
    }
}