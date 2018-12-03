using CGELib.Sprites.Shapes.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Actors
{
    public class Ball : CircleActor
    {
        public override bool Initialize()
        {            
            Radius = 10;
            Color = 5;
            return base.Initialize();
        }

        public override bool Update(long tick)
        {
            return true;
        }
    }
}
