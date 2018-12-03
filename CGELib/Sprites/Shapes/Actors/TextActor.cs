using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Sprites.Shapes.Actors
{
    public abstract class TextActor: ActingSprite
    {
        public virtual int Color { get; set; }
        public virtual string Text { get; set; } = "";
        public virtual FigletFont Font { get; set; }

        public override bool Initialize()
        {
            return true;
        }

        public override bool Render(ConsoleOutput screen)
        {
            if (Font == null)
                screen.WriteText(Center, Text, Color);
            else
                screen.WriteFiglet(Center, Text, Font, Color);            
            return true;
        }
    }
}
