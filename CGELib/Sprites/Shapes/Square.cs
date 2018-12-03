using CGELib.Sprites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Sprites.Shapes
{
    public class Square: Sprite
    {
        public virtual Point TopLeft { get; set; } = new Point(0, 0);
        public virtual Point BottomRight { get; set; } = new Point(0, 0);

        public virtual int Color { get; set; }

        public override bool Initialize()
        {
            return true;
        }

        public override bool Render(ConsoleOutput screen)
        {
            screen.Rectangle(TopLeft, BottomRight, Color);
            return true;
        }
    }
}
