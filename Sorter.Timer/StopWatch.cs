using System;

namespace Sorter.Timer
{
    public class StopWatch : ITimer
    {
        public double StartTime { get; private set; }

        public double StopTime { get; private set; }


        public double ElapsedTime
        {
            get { return StopTime - StartTime; }
        }

        public void Start()
        {
            StartTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
        }

        public void Stop()
        {
            StopTime = DateTime.Now.TimeOfDay.TotalMilliseconds;
        }
    }
}
