using CGELib.Scenes;

namespace CGELib.Engines
{
    public class ConsoleEngine: VisualEngine
    {
        protected ConsoleOutput consoleOutput;

        public override Scene Scene
        {
            get => base.Scene;
            set
            {
                if (value != null)
                {
                    value.Screen = consoleOutput;
                    //todo unload current scene?
                    base.Scene = value;
                }
            }
        }

        protected override bool Initialize()
        {
            consoleOutput = new ConsoleOutput(480, 254, 4, 4);

            consoleOutput.SetPalette(Palettes.Pico8);
            consoleOutput.Borderless(false);

            RendersPerSecond = 100;            
            return true;
        }

        protected override bool Run(long runTick)
        {
            consoleOutput.ClearBuffer();
            Scene?.Render(runTick);
            consoleOutput.DisplayBuffer();
            return true;
        }

        protected override bool Cleanup()
        {
            return true;
        }
    }
}
