using System;
using Sorter.Utilities._Timer;

namespace Sorter.Timer
{
    public class Timer : ITimer
    {
        private readonly ICurrentTimeProvider _currentTimeProvider;

        public int StartTimeInMilliseconds { get; set; }

        public int StopTimeInMilliseconds { get; set; }

        public int ElapsedTimeInMilliseconds { get { return Math.Max(0, StopTimeInMilliseconds - StartTimeInMilliseconds); } }


        public Timer()
        {
            _currentTimeProvider = new CurrentTimeProvider();
        }


        public Timer(ICurrentTimeProvider currentTimeProvider)
        {
            _currentTimeProvider = currentTimeProvider;
        }

        public void Start()
        {
            StartTimeInMilliseconds = _currentTimeProvider.CurrentTimeInMilliseconds();
        }

        public void Stop()
        {
            StopTimeInMilliseconds = _currentTimeProvider.CurrentTimeInMilliseconds();
        }
    }
}
