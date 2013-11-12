using System;
using Sorter.Algorithms.Routines;

namespace Sorter.Algorithms
{
    public class Sorter
    {
        private readonly SortRoutine _sortRoutine;

        public Sorter(SortRoutine sortRoutine)
        {
            _sortRoutine = sortRoutine;
        }

        public void Sort<TData>(TData[] dataToSort) where TData : IConvertible
        {
            _sortRoutine.Sort(dataToSort);
        }
    }
}
