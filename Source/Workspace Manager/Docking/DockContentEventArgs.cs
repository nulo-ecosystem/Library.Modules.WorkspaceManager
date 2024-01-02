using System;

namespace Nulo.Modules.WorkspaceManager.Docking {

    public class DockContentEventArgs(IDockContent content) : EventArgs {
        private readonly IDockContent m_content = content;

        public IDockContent Content {
            get { return m_content; }
        }
    }
}