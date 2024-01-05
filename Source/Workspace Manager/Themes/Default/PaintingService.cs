using Nulo.Modules.WorkspaceManager.Docking;

namespace Nulo.Modules.WorkspaceManager.Themes.Default {

    public class PaintingService : IPaintingService {
        private readonly IDictionary<KeyValuePair<int, int>, Pen> _penCache = new Dictionary<KeyValuePair<int, int>, Pen>();
        private readonly IDictionary<int, SolidBrush> _brushCache = new Dictionary<int, SolidBrush>();

        public SolidBrush GetBrush(Color color) {
            var key = color.ToArgb();
            if(_brushCache.TryGetValue(key, out SolidBrush value)) { return value; }

            var result = new SolidBrush(color);
            _brushCache.Add(key, result);
            return result;
        }

        public Pen GetPen(Color color, int thickness) {
            var key = new KeyValuePair<int, int>(color.ToArgb(), thickness);
            if(_penCache.TryGetValue(key, out Pen value)) { return value; }

            var result = new Pen(color, thickness);
            _penCache.Add(key, result);
            return result;
        }

        public void CleanUp() {
            foreach(var pen in _penCache) {
                pen.Value.Dispose();
            }

            _penCache.Clear();

            foreach(var brush in _brushCache) {
                brush.Value.Dispose();
            }

            _brushCache.Clear();
        }
    }
}