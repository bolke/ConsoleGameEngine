using System;
using System.Threading;

namespace CGELib
{
    public abstract class TimedEngine
    {
        private Thread _thread = null;        

        public long Tick { get { return DateTime.UtcNow.Ticks; } }
        public long LastTick { get; set; } = DateTime.MinValue.Ticks;
        public long TicksPerFrame { get; protected set; }
        public bool IsRunning { get; set; } = false;

        protected abstract bool Initialize();
        protected abstract bool Run(long runTick);
        protected abstract bool Cleanup();

        public TimedEngine()
        {
            _thread = new Thread(new ThreadStart(Main));
        }

        public bool Start()
        {
            if (!IsRunning)
            {
                IsRunning = true;
                _thread.Start();
                return true;
            }
            return false;
        }

        public void Main()
        {
            Initialize();
            long runTick;
            while (IsRunning)
            {
                runTick = Tick;
                Run(runTick);
                runTick = (TicksPerFrame - (Tick - runTick)) / 10000;
                if(runTick>0)
                    Thread.Sleep((int)runTick);
            }
            Cleanup();
        }
    }
}
