using System;

namespace Sorter.Algorithms.Interfaces
{
    public interface IProgressable<TEventArgs> where TEventArgs : EventArgs
    {
        event EventHandler<TEventArgs> Started;

        event EventHandler<TEventArgs> InProgress;

        event EventHandler<TEventArgs> Completed;
    }

    public interface IProgressable<TStartArgs, TInProgArgs, TCompleteArgs> 
        where TStartArgs : EventArgs
        where TInProgArgs : EventArgs
        where TCompleteArgs : EventArgs
    {
        event EventHandler<TStartArgs> Started;

        event EventHandler<TInProgArgs> InProgress;

        event EventHandler<TCompleteArgs> Completed;    
    }
}
