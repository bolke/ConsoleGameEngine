using CGELib;
using CGELib.Scenes;
using Pong.Actors;

namespace CGEDemoLib.Pong
{
    public class PongScene: Scene
    {
        private Ball ball = new Ball();
        private Bar left = new Bar();
        private Bar right = new Bar();
        private Score score = new Score();

        public override bool Initialize()
        {            
            ball.Initialize();
            ball.Center.X = 240;
            ball.Center.Y = 127;
            ball.Radius = 10;
            ball.Color = 3;

            left.Initialize();
            left.Center.X = 10;
            left.Center.Y = 127;
            left.Color = 3;
            left.Scale = 0.5f;

            right.Initialize();
            right.Center.X = 460;
            right.Center.Y = 127;
            right.Color = 3;

            score.Initialize();
            score.Center.X = 240;
            score.Center.Y = 10;            
            score.Font = FigletFont.Load("Standard.flf");
            score.Color = 3;            
            
            AddSprite(ball);
            AddSprite(left);
            AddSprite(right);
            AddSprite(score);
            return true;
        }

        public override bool Update(long tick)
        {
            
            return base.Update(tick);
        }
    }
}
