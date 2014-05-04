namespace Sorter.Utilities.Interfaces
{
    public interface ITimer
    {
        long TimeElapsedMs { get; }
        
        void StartTimer();
        
        void StopTimer();

        void ResetTimer();
    }
}
