using System;

namespace Sorter.Algorithms.EventArg
{
    public sealed class SortCompleteEventArgs : EventArgs
    {
        public int StartTimeMilliSec { get; private set; }

        public int StopTimeMilliSec { get; private set; }

        public long ElapsedTimeMilliSec { get; private set; }

        public int ItemSortCount { get; private set; }


        public SortCompleteEventArgs(long elapsedTimeMilliSec, int itemSortCount)
        {
            ElapsedTimeMilliSec = elapsedTimeMilliSec;
            ItemSortCount = itemSortCount;
        }
    }
}
