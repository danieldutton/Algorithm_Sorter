namespace Sorter.Timer
{
    public interface ITimer
    {
        double StartTime { get;  }

        double StopTime { get;  }

        double ElapsedTime { get;  }

        void Start();

        void Stop();
    }
}
