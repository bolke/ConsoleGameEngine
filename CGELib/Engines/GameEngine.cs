using CGELib.Scenes;

namespace CGELib.Engines
{
    public class GameEngine: LogicEngine
    {         
        public VisualEngine VisualEngine { get; set; }

        protected override bool Cleanup()
        {
            throw new System.NotImplementedException();
        }

        protected override bool Initialize()
        {
            VisualEngine.Start();
            return base.Initialize();
        }

        protected override bool Run(long runTick)
        {
            if (VisualEngine?.Scene != null)
                VisualEngine.Scene.Update(runTick);
            return true;
        }
    }
}
