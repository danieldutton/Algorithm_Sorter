namespace Sorter.Utilities._Timer
{
    public interface IStopwatch
    {
        void Start();
        void Stop();
        long ElapsedMilliseconds { get; }
    }
}
