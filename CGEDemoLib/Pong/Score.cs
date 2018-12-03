using CGELib.Sprites.Shapes.Actors;

namespace Pong.Actors
{
    public class Score : TextActor
    {
        int _leftScore = 0;
        int _rightScore = 0;

        public override bool Initialize()
        {                 
            return base.Initialize();
        }

        public override bool Update(long tick)
        {            
            Text = $"{_leftScore}:{_rightScore}";
            return true;
        }
    }
}
