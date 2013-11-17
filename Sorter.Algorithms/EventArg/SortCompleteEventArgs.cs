using System;

namespace Sorter.Algorithms.EventArg
{
    public sealed class SortCompleteEventArgs : EventArgs
    {
        public long ElapsedTimeMilliSec { get; private set; }

        public int ItemSortCount { get; private set; }


        public SortCompleteEventArgs(long elapsedTimeMilliSec, int itemSortCount)
        {
            ElapsedTimeMilliSec = elapsedTimeMilliSec;
            ItemSortCount = itemSortCount;
        }
    }
}
