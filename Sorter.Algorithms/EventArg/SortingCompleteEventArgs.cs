using System;

namespace Sorter.Algorithms.EventArg
{
    public class SortingCompleteEventArgs : EventArgs
    {
        public double StartTimeInMs { get; private set; }

        public double StopTimeInMs { get; private set; }

        public double ElapsedTimeInMs { get; private set; }


        public SortingCompleteEventArgs(double startTime, double stopTime, double elapsedTime)
        {
            StartTimeInMs = startTime;
            StopTimeInMs = stopTime;
            ElapsedTimeInMs = elapsedTime;
        }
    }
}
