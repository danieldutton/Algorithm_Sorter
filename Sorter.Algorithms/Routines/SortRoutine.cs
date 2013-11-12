using System;
using Sorter.Algorithms.Interfaces;

namespace Sorter.Algorithms.Routines
{
    public abstract class SortRoutine : IProgressReportable<EventArgs>
    {
        public event EventHandler<EventArgs> Started;
       
        public event EventHandler<EventArgs> InProgress;

        public event EventHandler<EventArgs> Completed;


        public abstract void Sort<TData>(TData[] data) where TData : IConvertible;


        protected virtual void OnStarted()
        {
            EventHandler<EventArgs> handler = Started;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnInProgress()
        {
            EventHandler<EventArgs> handler = InProgress;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnCompleted()
        {
            EventHandler<EventArgs> handler = Completed;
            if (handler != null) handler(this, EventArgs.Empty);
        }        
    }
}
