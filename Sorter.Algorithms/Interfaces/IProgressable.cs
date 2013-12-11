using System;

namespace Sorter.Algorithms.Interfaces
{
    public interface IProgressable<TEventArgs> where TEventArgs : EventArgs
    {
        event EventHandler<TEventArgs> Started;

        event EventHandler<TEventArgs> Completed;
    }

    public interface IProgressable<TStartArgs, TCompleteArgs> 
        where TStartArgs : EventArgs
        where TCompleteArgs : EventArgs
    {
        event EventHandler<TStartArgs> Started;

        event EventHandler<TCompleteArgs> Completed;    
    }
}
