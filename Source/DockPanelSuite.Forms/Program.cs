using DockPanelSuite.Forms.Modules.WorkspaceManager;
using DockPanelSuite.Forms.Pages;
using Nulo.Modules.WorkspaceManager;

namespace DockPanelSuite.Forms {

    internal static class Program {

        public static WorkspaceManager<WorkspaceTheme, WorkspaceData> WorkspaceManager;

        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();

            //Properties.Settings.Default.Reset();
            WorkspaceManager = new WorkspaceManager<WorkspaceTheme, WorkspaceData>();

            Application.Run(new MainPage());
        }
    }
}