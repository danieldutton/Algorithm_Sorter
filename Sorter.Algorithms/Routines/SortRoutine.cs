using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Timer;
using System;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public abstract class SortRoutine : IProgressable<EventArgs, EventArgs, SortCompleteEventArgs>
    {
        public event EventHandler<EventArgs> Started;
       
        public event EventHandler<EventArgs> InProgress;

        public event EventHandler<SortCompleteEventArgs> Completed;
       
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

        protected virtual void OnCompleted(SortCompleteEventArgs e)
        {
            EventHandler<SortCompleteEventArgs> handler = Completed;
            if (handler != null) handler(this, e);
        }
      
    }
}
