using DockPanelSuite.Forms.Modules.LayoutManager;
using DockPanelSuite.Forms.Pages;
using Nulo.Modules.DockPanelSuite.LayoutManager;

namespace DockPanelSuite.Forms {

    internal static class Program {

        public static LayoutManager<LayoutTheme, LayoutData> LayoutManager;

        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();

            LayoutManager = new LayoutManager<LayoutTheme, LayoutData>();
            LayoutManager.SetTheme(null);

            Application.Run(new MainPage());
        }
    }
}