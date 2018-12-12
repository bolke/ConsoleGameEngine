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
        private int _radius = 0;
        public virtual int Radius { get { return (int)Math.Round(_radius * Scale); } set { _radius = value; } }
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
