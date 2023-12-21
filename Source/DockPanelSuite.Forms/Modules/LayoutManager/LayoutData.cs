using Nulo.Modules.DockPanelSuite.Docking;
using Nulo.Modules.DockPanelSuite.LayoutManager;

namespace DockPanelSuite.Forms.Modules.LayoutManager {

    public class LayoutData : ILayoutData {

        //Gerenciamento do layout atual do usuário
        public string LoadCurrentLayout() {
            if(string.IsNullOrEmpty(Properties.Settings.Default.Layout)) {
                return LoadDefaultLayout();
            } else {
                return Properties.Settings.Default.Layout;
            }
        }
        public void SaveCurrentLayout(string content) {
            Properties.Settings.Default.Layout = content;
            Properties.Settings.Default.Save();
        }

        //Gerenciamento dos layouts padrões do software
        public List<Layout> LoadAllDefaultLayouts() {
            return [
                new("Default", nameof(DefaultLayouts.DefaultLayout)),
                new("4 Split", nameof(DefaultLayouts.FourSplitLayout)),
                new("Empty", nameof(DefaultLayouts.EmptyLayout))
            ];
        }
        public string LoadDefaultLayout(string key = null) {
            switch(key) {
                case nameof(DefaultLayouts.DefaultLayout): { return DefaultLayouts.DefaultLayout; }
                case nameof(DefaultLayouts.FourSplitLayout): { return DefaultLayouts.FourSplitLayout; }
                default: { return DefaultLayouts.EmptyLayout; }
            }
        }

        //Gerenciamento dos layouts do usuário
        public List<string> LoadAllUserLayouts() {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;
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
        public string LoadUserLayout(string name) {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;
            foreach(UserLayout layout in userLayouts) {
                if(layout.Name.Equals(name)) {
                    return layout.Content;
                }
            }

            return null;
        }
        public bool SaveUserLayout(string name, string xmlContent) {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;
            userLayouts.Add(new UserLayout { Name = name, Content = xmlContent });
            Properties.Settings.Default.UserLayouts = userLayouts;
            Properties.Settings.Default.Save();
            return true;
        }
        public bool RemoveUserLayout(string name) {
            List<UserLayout> userLayouts = Properties.Settings.Default.UserLayouts;

            foreach(UserLayout layout in userLayouts) {
                if(layout.Name.Equals(name)) {
                    userLayouts.Remove(layout);
                    Properties.Settings.Default.UserLayouts = userLayouts;
                    Properties.Settings.Default.Save();
                    return true;
                }
            }

            return false;
        }

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