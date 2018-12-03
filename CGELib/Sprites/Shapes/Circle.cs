using CGELib;
using CGELib.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Sprites.Shapes
{
    public class Circle : Sprite
    {
        public virtual int Radius { get; set; }
        public virtual int Color { get; set; }

        public override bool Initialize()
        {
            return true;
        }

        public override bool Render(ConsoleOutput screen)
        {
            screen.Arc(Center, Radius, Color);
            return true;
        }
    }
}
