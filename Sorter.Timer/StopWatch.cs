using System;

namespace Sorter.Timer
{
    public class StopWatch : ITimer
    {
        public double StartTime { get; set; }

        public double StopTime { get; set; }
        
        public double ElapsedTime { get; set; }


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
