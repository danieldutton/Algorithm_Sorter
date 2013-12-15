using System;

namespace Sorter.Algorithms.Interfaces
{
    public interface IProgressable<TEventArgs> where TEventArgs : EventArgs
    {
        event EventHandler<TEventArgs> Started;

        event EventHandler<TEventArgs> Completed;

        event EventHandler<TEventArgs> Cancelled;
    }

    public interface IProgressable<TStartArgs, TCompleteArgs, TCancelledArgs> 
        where TStartArgs : EventArgs
        where TCompleteArgs : EventArgs
        where TCancelledArgs : EventArgs
    {
        event EventHandler<TStartArgs> Started;

        event EventHandler<TCompleteArgs> Completed;

        event EventHandler<TCancelledArgs> Cancelled;
    }
}
