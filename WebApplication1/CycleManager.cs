using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;

namespace WebApplication1
{
    public class CycleManager
    {
        private int _cycleLength;
        private bool _isStarted = false;
        private Timer _timer;

        public int cycleLength
        {
            get { return _cycleLength; }
            set
            {
                _cycleLength = value;
                if (this._isStarted == true)
                {
                    this._timer.Interval = this._cycleLength;
                }
                else
                {
                    this._timer = new Timer(this._cycleLength);
                    this._timer.AutoReset = true;
                    this._timer.Start();
                }
                ;
            }
        }

        public void AddToCycle(ElapsedEventHandler handler)
        {
            this._timer.Elapsed += handler;
        }

        public void RemoveFromCycle(ElapsedEventHandler handler)
        {
            this._timer.Elapsed -= handler;
        }
    }
}
