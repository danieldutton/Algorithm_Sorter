using Sorter.Utilities.DateTimes;

namespace Sorter.Timer
{
    public class Timer : ITimer
    {
        private readonly ICurrentTimeProvider _currentTimeProvider;

        public double StartTime { get; set; }

        public double StopTime { get; set; }

        public double ElapsedTime { get { return StopTime - StartTime; } }


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
            StartTime = _currentTimeProvider.CurrentTimeInMilliseconds();
        }

        public void Stop()
        {
            StopTime = _currentTimeProvider.CurrentTimeInMilliseconds();
        }
    }
}
