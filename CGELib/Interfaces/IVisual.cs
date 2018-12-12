using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Interfaces
{
    public interface IVisual
    {
        int Width { get; set; }
        int Height { get; set; }
        double Scale { get; set; }
        double Rotation { get; set; }
    }
}
