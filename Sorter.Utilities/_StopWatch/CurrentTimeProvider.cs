using System;

namespace Sorter.Utilities.DateTimes
{
    public class CurrentTimeProvider : ICurrentTimeProvider
    {
        public double CurrentTimeInMilliseconds()
        {
            return DateTime.Now.TimeOfDay.Milliseconds;
        }
    }
}
