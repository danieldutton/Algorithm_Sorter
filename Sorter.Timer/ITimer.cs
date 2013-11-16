namespace Sorter.Timer
{
    public interface ITimer
    {
        int StartTimeInMilliseconds { get;  }

        int StopTimeInMilliseconds { get;  }

        int ElapsedTimeInMilliseconds { get;  }

        void Start();

        void Stop();
    }
}
