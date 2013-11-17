namespace Sorter.Utilities._Timer
{
    public class Stopwatch : IStopwatch
    {
        private readonly System.Diagnostics.Stopwatch _stopWatch = new System.Diagnostics.Stopwatch();

        public void Start()
        {
            _stopWatch.Start();
        }

        public void Stop()
        {
            _stopWatch.Stop();
        }

        public long ElapsedMilliseconds { get { return _stopWatch.ElapsedMilliseconds; } }
    }
}
