using Nulo.Modules.DockPanelSuite.Docking;
using Nulo.Modules.DockPanelSuite.LayoutManager;

namespace DockPanelSuite.Forms.Modules.LayoutManager {

    public class LayoutData : ILayoutData {

        #region Current Layout Manager
        public string LoadCurrentLayout() {
            return string.IsNullOrEmpty(Properties.Settings.Default.Layout) ? LoadDefaultLayout() : Properties.Settings.Default.Layout;
        }
        public void SaveCurrentLayout(string content) {
            Properties.Settings.Default.Layout = content;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region Default Layout Manager
        public List<Layout> LoadAllDefaultLayouts() => [
            new Layout("Default", nameof(DefaultLayouts.DefaultLayout)),
            new Layout("4 Split", nameof(DefaultLayouts.FourSplitLayout)),
            new Layout("Empty", nameof(DefaultLayouts.EmptyLayout))
        ];
        public string LoadDefaultLayout(string key = null) {
            switch(key) {
                case nameof(DefaultLayouts.DefaultLayout): { return DefaultLayouts.DefaultLayout; }
                case nameof(DefaultLayouts.FourSplitLayout): { return DefaultLayouts.FourSplitLayout; }
                default: { return DefaultLayouts.EmptyLayout; }
            }
        }
        #endregion

        #region User Layout Manager
        public List<string> LoadAllUserLayouts() {
            var userLayouts = Properties.Settings.Default.UserLayouts;

            if(userLayouts == null) {
                userLayouts = [];
                Properties.Settings.Default.UserLayouts = userLayouts;
                Properties.Settings.Default.Save();
            }

            List<string> layouts = [];
            foreach(UserLayout layout in userLayouts) {
                layouts.Add(layout.Name);
            }

            return layouts;
        }
        public string LoadUserLayout(string key) {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;
            foreach(UserLayout layout in userLayouts) {
                if(layout.Name.Equals(key)) {
                    return layout.Content;
                }
            }

            return null;
        }
        public bool SaveUserLayout(string key, string xmlContent) {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;
            userLayouts.Add(new UserLayout { Name = key, Content = xmlContent });
            Properties.Settings.Default.UserLayouts = userLayouts;
            Properties.Settings.Default.Save();
            return true;
        }
        public bool RemoveUserLayout(string key) {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;

            foreach(UserLayout layout in userLayouts) {
                if(layout.Name.Equals(key)) {
                    userLayouts.Remove(layout);
                    Properties.Settings.Default.UserLayouts = userLayouts;
                    Properties.Settings.Default.Save();
                    return true;
                }
            }

            return false;
        }
        #endregion

        //Carregamento de instâncias de paineis
        public IDockContent GetInstanceByPersistString(string persistString) {
            try {
                return Activator.CreateInstance(Type.GetType(persistString)) as IDockContent;
            } catch {
                return null;
            }
        }
    }

    public class UserLayout {

        public string Name { get; set; }
        public string Content { get; set; }
    }
}