using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Interfaces
{
    public interface ISprite
    {
        Point Center { get; set; }
        bool Render(ConsoleOutput screen);

        bool Initialize();
    }
}
