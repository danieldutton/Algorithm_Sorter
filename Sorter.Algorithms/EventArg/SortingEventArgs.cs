using System;

namespace Sorter.Algorithms.EventArg
{
    public class SortingEventArgs : EventArgs
    {
        public double StartTime { get; private set; }

        public double StopTime { get; private set; }

        public double ElapsedTime
        {
            get { return StopTime - StartTime; }
        }


        public SortingEventArgs(double startTime, double stopTime)
        {
            StartTime = startTime;
            StopTime = stopTime;
        }
    }
}
