using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Utilities._Stopwatch;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public abstract class SortRoutine : IProgressable<EventArgs, SortCompleteEventArgs, EventArgs>
    {
        public event EventHandler<EventArgs> Started;     

        public event EventHandler<SortCompleteEventArgs> Completed;
        
        public event EventHandler<EventArgs> Cancelled;

        protected IStopwatch Stopwatch;


        protected SortRoutine(IStopwatch stopWatch)
        {
            Stopwatch = stopWatch;
        }

        public abstract Task<int[]> SortAsync(int[] data, CancellationToken cancelToken); 


        protected virtual void OnStarted()
        {
            EventHandler<EventArgs> handler = Started;
            if (handler != null) handler(this, EventArgs.Empty);
        }

        protected virtual void OnCompleted(SortCompleteEventArgs e)
        {
            EventHandler<SortCompleteEventArgs> handler = Completed;
            if (handler != null) handler(this, e);
        }

        protected virtual void OnCancelled()
        {
            EventHandler<EventArgs> handler = Cancelled;
            if (handler != null) handler(this, EventArgs.Empty);
        }
    }
}
