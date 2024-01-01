namespace Nulo.Modules.WorkspaceManager {

    public class Texts {
        public string SaveMenuItem { get; set; } = "Save as New Workspace...";
        public string NewWorkspaceTitle { get; set; } = "New Workspace";
        public string NewWorkspaceName { get; set; } = "Name";
        public string NewWorkspaceMessageErrorDuplicate { get; set; } = "Name already exists! Try another name.";
        public string NewWorkspaceMessageErrorInvalidCharacter { get; set; } = "Invalid characters! Avoid using";

        public string DeleteMenuItem { get; set; } = "Delete a Workspace...";
        public string DeleteWorkspaceTitle { get; set; } = "Delete Workspace";
        public string DeleteWorkspaceSelect { get; set; } = "Select";

        public string CommandSave { get; set; } = "Save";
        public string CommandDelete { get; set; } = "Delete";
    }
}