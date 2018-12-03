using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGELib.Engines
{
    public abstract class LogicEngine : TimedEngine
    {
        private int _framesPerSecond = 1;

        public int UpdatesPerSecond
        {
            get { return _framesPerSecond; }
            set
            {
                _framesPerSecond = value > 0 ? value : 1;
                TicksPerFrame = 10000000 / _framesPerSecond;
            }
        }

        protected override bool Initialize()
        {
            UpdatesPerSecond = 1;
            return true;
        }
    }
}
