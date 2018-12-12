using CGEDemoLib.Pong;
using CGELib.Engines;
using System.Threading;

namespace Pong
{
    class Program
    {
        static void Main(string[] args)
        {
            GameEngine game = new GameEngine();
            game.VisualEngine = new ConsoleEngine();            
            
            game.Start();

            PongScene scene = new PongScene();

            scene.Initialize();

            Thread.Sleep(1000);

            game.VisualEngine.RendersPerSecond = 20;
            game.UpdatesPerSecond = 200;

            game.VisualEngine.Scene = scene;

            while (game.IsRunning)
            {
                Thread.Sleep(1000);
            }

        }
    }
}
