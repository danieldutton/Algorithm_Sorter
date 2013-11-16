using System;

namespace Sorter.Utilities._Timer
{
    public class CurrentTimeProvider : ICurrentTimeProvider
    {
        public int CurrentTimeInMilliseconds()
        {
            return DateTime.Now.Millisecond;
        }
    }
}
