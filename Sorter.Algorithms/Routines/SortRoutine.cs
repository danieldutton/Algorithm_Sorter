using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Utilities.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public abstract class SortRoutine : IProgressable<EventArgs, SortFinishedEventArg, EventArgs>
    {
        public event EventHandler<EventArgs> Started;     

        public event EventHandler<SortFinishedEventArg> Complete;
        
        public event EventHandler<EventArgs> Cancelled;

        protected ITimer Timer;


        protected SortRoutine(ITimer timer)
        {
            Timer = timer;
        }

        public abstract Task<int[]> SortAsync(int[] data, CancellationToken cancelToken); 


        protected virtual void OnStarted()
        {
            EventHandler<EventArgs> handler = Started;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnComplete(SortFinishedEventArg e)
        {
            EventHandler<SortFinishedEventArg> handler = Complete;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnCancelled()
        {
            EventHandler<EventArgs> handler = Cancelled;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
