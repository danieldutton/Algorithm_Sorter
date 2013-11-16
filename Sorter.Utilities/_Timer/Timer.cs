using System;

namespace Sorter.Utilities._StopWatch
{
    public class CurrentTimeProvider : ICurrentTimeProvider
    {
        public double CurrentTimeInMilliseconds()
        {
            return DateTime.Now.Millisecond;
        }
    }
}
