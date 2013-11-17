using System.Diagnostics;

namespace Sorter.Utilities._Stopwatch
{
    public class SortStopwatch : IStopwatch
    {
        private readonly Stopwatch _stopWatch = new Stopwatch();

        public long ElapsedMilliseconds
        {
            get { return _stopWatch.ElapsedMilliseconds; }
        }

        public void Start()
        {
            _stopWatch.Start();
        }

        public void Stop()
        {
            _stopWatch.Stop();
        }
    }
}
