using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Sprites.Shapes.Actors
{
    public abstract class SquareActor: ActingSprite
    {
        public virtual Point TopLeft { get; set; } = new Point(0,0);
        public virtual Point BottomRight { get; set; } = new Point(0, 0);

        public int Width { get; set; }
        public int Height { get; set; }

        public virtual int Color { get; set; }

        public override bool Initialize()
        {
            return true;
        }

        public override bool Render(ConsoleOutput screen)
        {
            TopLeft.X = Center.X - Width / 2;
            TopLeft.Y = Center.Y - Height / 2;
            BottomRight.X = Center.X + Width / 2;
            BottomRight.Y = Center.Y + Height / 2;

            screen.Rectangle(TopLeft, BottomRight, Color);
            return true;
        }
    }
}
