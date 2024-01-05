using Nulo.Modules.WorkspaceManager;
using Nulo.Pages;

namespace Nulo {

    internal static class Program {
        public static WorkspaceManager<WorkspaceTheme, WorkspaceData> WorkspaceManager;

        [STAThread]
        private static void Main() {
            ApplicationConfiguration.Initialize();

            WorkspaceManager = new WorkspaceManager<WorkspaceTheme, WorkspaceData>();

            Application.Run(new MainPage());
        }
    }
}