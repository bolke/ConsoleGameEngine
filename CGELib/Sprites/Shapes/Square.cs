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
        public virtual Point TopLeft { get { return new Point(Center.X - Width / 2, Center.Y - Height / 2); } }
        public virtual Point BottomRight { get { return new Point(Center.X + Width / 2, Center.Y + Height / 2); } }

        public virtual int Color { get; set; }

        public override bool Initialize()
        {
            return true;
        }

        public override bool Render(ConsoleOutput screen)
        {
            screen.Rectangle(this);
            return true;
        }
    }
}
