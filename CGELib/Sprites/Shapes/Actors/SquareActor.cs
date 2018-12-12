using CGELib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Sprites.Shapes.Actors
{
    public abstract class SquareActor: Square, IActor
    {
        public abstract bool Update(long tick);
    }
}
