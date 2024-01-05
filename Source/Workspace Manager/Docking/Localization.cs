namespace Nulo.Modules.WorkspaceManager.Docking {

    [AttributeUsage(AttributeTargets.All)]
    internal sealed class LocalizedDescriptionAttribute(string key) : DescriptionAttribute(key) {
        private bool m_initialized = false;

        public override string Description {
            get {
                if(!m_initialized) {
                    string key = base.Description;
                    DescriptionValue = ResourceHelper.GetString(key);
                    DescriptionValue ??= String.Empty;
                    m_initialized = true;
                }
                return DescriptionValue;
            }
        }
    }

    [AttributeUsage(AttributeTargets.All)]
    internal sealed class LocalizedCategoryAttribute(string key) : CategoryAttribute(key) {
        protected override string GetLocalizedString(string value) {
            return ResourceHelper.GetString(value);
        }
    }
}