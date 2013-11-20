using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Utilities._Stopwatch;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public abstract class SortRoutine : IProgressable<EventArgs, EventArgs, SortCompleteEventArgs>
    {
        public event EventHandler<EventArgs> Started;
       
        public event EventHandler<EventArgs> InProgress;

        public event EventHandler<SortCompleteEventArgs> Completed;

        
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
