using System;
using Sorter.Utilities.DateTimes;

namespace Sorter.Timer
{
    public class Timer : ITimer
    {
        private ICurrentTimeProvider _currentTimeProvider;

        public double StartTime { get; set; }

        public double StopTime { get; set; }
        
        public double ElapsedTime { get; set; }


        public Timer(ICurrentTimeProvider currentTimeProvider)
        {
            _currentTimeProvider = currentTimeProvider;
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
