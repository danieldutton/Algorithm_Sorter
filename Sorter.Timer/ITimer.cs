namespace Sorter.Timer
{
    public interface ITimer
    {
        double StartTime { get; set; }

        double StopTime { get; set; }

        double ElapsedTime { get; }

        double Start();

        double Stop();
    }
}
