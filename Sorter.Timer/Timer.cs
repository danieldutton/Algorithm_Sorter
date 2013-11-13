using System;

namespace Sorter.Timer
{
    public class Timer : ITimer
    {
        public double StartTime { get; set; }

        public double StopTime { get; set; }

        public double ElapsedTime
        {
            get { return StopTime - StartTime; }
        }

        public double Start()
        {
            StartTime = DateTime.Now.TimeOfDay.TotalMilliseconds;

            return StartTime;
        }

        public double Stop()
        {
            StopTime = DateTime.Now.TimeOfDay.TotalMilliseconds;

            return StopTime;
        }
    }
}
