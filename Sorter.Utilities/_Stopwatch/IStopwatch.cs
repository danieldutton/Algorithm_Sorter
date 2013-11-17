namespace Sorter.Utilities._Stopwatch
{
    public interface IStopwatch
    {
        void Start();
        void Stop();
        long ElapsedMilliseconds { get; }
    }
}
