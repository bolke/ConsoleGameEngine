using CGELib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Sprites
{
    public abstract class Sprite : ISprite
    {
        public virtual Point Center {get; set; } = new Point(0, 0);

        public abstract bool Render(ConsoleOutput screen);
        public abstract bool Initialize();
    }
}
