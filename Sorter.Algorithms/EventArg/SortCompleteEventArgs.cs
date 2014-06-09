using System;

namespace Sorter.Algorithms.EventArg
{
    public sealed class SortCompleteEventArgs : EventArgs
    {
        public long ElapsedTimeMilliSec { get; private set; }

        public int ItemSortCount { get; private set; }

        public bool WasCancelled { get; private set; }


        public SortCompleteEventArgs(long elapsedTimeMilliSec, int itemSortCount, bool wasCancelled)
        {
            ElapsedTimeMilliSec = elapsedTimeMilliSec;
            ItemSortCount = itemSortCount;
            WasCancelled = wasCancelled;
        }
    }
}
