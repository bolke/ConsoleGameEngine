using CGELib.Interfaces;
using System;

namespace CGELib.Sprites
{
    public abstract class Sprite : ISprite
    {
        private int _width = 0;
        private int _height = 0;

        public virtual Point Center {get; set; } = new Point(0, 0);
        public int Width { get { return (int)Math.Round(_width * Scale); } set { _width = value; } }
        public int Height { get { return (int)Math.Round(_height * Scale); } set { _height = value; } }
        public double Scale { get; set; }
        public double Rotation { get; set; } = 0; 
        public abstract bool Render(ConsoleOutput screen);
        public abstract bool Initialize();
    }
}
