using CGELib.Scenes;

namespace CGELib.Engines
{
    public abstract class VisualEngine : TimedEngine
    {
        private int _rendersPerSecond = 1;

        public virtual Scene Scene { get; set; }
        public int RendersPerSecond
        {
            get { return _rendersPerSecond; }
            set
            {
                _rendersPerSecond = value > 0 ? value : 1;
                TicksPerFrame = 10000000 / _rendersPerSecond;
            }
        }
    }
}
