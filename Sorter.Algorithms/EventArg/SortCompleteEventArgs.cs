using System;

namespace Sorter.Algorithms.EventArg
{
    public sealed class SortCompleteEventArgs : EventArgs
    {
        public int StartTimeMilliSec { get; private set; }

        public int StopTimeMilliSec { get; private set; }

        public int ElapsedTimeMilliSec { get; private set; }

        public int ItemSortCount { get; private set; }


        public SortCompleteEventArgs(int startTimeMilliSec, int stopTimeMilliSec, 
                                     int elapsedTimeMilliSec, int itemSortCount)
        {
            StartTimeMilliSec = startTimeMilliSec;
            StopTimeMilliSec = stopTimeMilliSec;
            ElapsedTimeMilliSec = elapsedTimeMilliSec;
            ItemSortCount = itemSortCount;
        }
    }
}
