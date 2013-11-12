using System;

namespace Sorter.Algorithms.Interfaces
{
    public interface IProgressReportable<TEventArgs> where TEventArgs : EventArgs
    {
        event EventHandler<TEventArgs> Started;

        event EventHandler<TEventArgs> InProgress;

        event EventHandler<TEventArgs> Completed;
    }


    public interface IProgressReportable<TStartedArgs, TInProgressArgs, TCompletedArgs> 
        where TStartedArgs : EventArgs
        where TInProgressArgs : EventArgs
        where TCompletedArgs : EventArgs
    {
        event EventHandler<TStartedArgs> Started;

        event EventHandler<TInProgressArgs> InProgress;

        event EventHandler<TCompletedArgs> Completed;
    }
}
