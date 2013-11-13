using System;

namespace Sorter.Algorithms.EventArg
{
    public sealed class SortCompleteEventArgs : EventArgs
    {
        public double StartTimeMilliSec { get; private set; }

        public double StopTimeMilliSec { get; private set; }

        public double ElapsedTimeMilliSec { get; private set; }


        public SortCompleteEventArgs(double startTimeMilliSec, double stopTimeMilliSec, 
                                     double elapsedTimeMilliSec)
        {
            StartTimeMilliSec = startTimeMilliSec;
            StopTimeMilliSec = stopTimeMilliSec;
            ElapsedTimeMilliSec = elapsedTimeMilliSec;
        }
    }
}
