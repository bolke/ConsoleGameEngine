using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Interfaces
{
    public interface IScene: IVisual
    {
        List<IActor> Actors { get; set; }
        List<ISprite> Sprites { get; set; }

        ConsoleOutput Screen { get; set; }

        bool Initialize();

        bool Update(long tick);
        bool Render(long tick);        
    }
}
