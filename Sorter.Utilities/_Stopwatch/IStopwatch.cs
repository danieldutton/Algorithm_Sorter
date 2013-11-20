namespace Sorter.Utilities._Stopwatch
{
    public interface IStopwatch
    {
        long ElapsedMilliseconds { get; }
        void Start();
        void Stop();   
    }
}
