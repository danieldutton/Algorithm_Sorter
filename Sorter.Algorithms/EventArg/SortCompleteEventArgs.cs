using System;

namespace Sorter.Algorithms.EventArg
{
    public sealed class SortCompleteEventArgs : EventArgs
    {
        public double StartTimeInMs { get; private set; }

        public double StopTimeInMs { get; private set; }

        public double ElapsedTimeInMs { get; private set; }


        public SortCompleteEventArgs(double startTime, double stopTime, double elapsedTime)
        {
            StartTimeInMs = startTime;
            StopTimeInMs = stopTime;
            ElapsedTimeInMs = elapsedTime;
        }
    }
}
