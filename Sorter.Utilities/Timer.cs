using Sorter.Utilities.Interfaces;
using System.Diagnostics;

namespace Sorter.Utilities
{
    public class Timer : ITimer
    {
        private readonly Stopwatch _stopWatch = new Stopwatch();

        public long TimeElapsedMs
        {
            get { return _stopWatch.ElapsedMilliseconds; }
        }

        public void StartTimer()
        {
            _stopWatch.Start();
        }

        public void StopTimer()
        {
            _stopWatch.Stop();
        }

        public void ResetTimer()
        {
            _stopWatch.Reset();
        }
    }
}
