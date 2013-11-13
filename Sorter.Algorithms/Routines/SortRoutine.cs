using System;
using System.Threading.Tasks;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Timer;

namespace Sorter.Algorithms.Routines
{
    public abstract class SortRoutine : IProgressReportable<EventArgs>
    {
        public event EventHandler<EventArgs> Started;
       
        public event EventHandler<EventArgs> InProgress;

        public event EventHandler<SortingCompleteEventArgs> Completed;
       
        protected ITimer Timer;


        protected SortRoutine(ITimer timer)
        {
            Timer = timer;
        }

        public abstract Task<int[]> SortAsync(int[] data); 


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

        protected virtual void OnCompleted(SortingCompleteEventArgs e)
        {
            EventHandler<SortingCompleteEventArgs> handler = Completed;
            if (handler != null) handler(this, e);
        }
      
    }
}
