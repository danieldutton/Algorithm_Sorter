using Sorter.Algorithms.Routines;
using System;
using System.Threading.Tasks;

namespace Sorter.Algorithms
{
    public class SorterContext
    {
        private readonly SortRoutine _sortRoutine;

        public SorterContext(SortRoutine sortRoutine)
        {
            _sortRoutine = sortRoutine;
        }

        public Task<int[]> Sort(int[] dataToSort)
        {
            if(dataToSort == null) 
                throw new ArgumentNullException("dataToSort");
            
            if(dataToSort.Length == 1) 
                throw new ArgumentOutOfRangeException("dataToSort");

            return _sortRoutine.SortAsync(dataToSort);
        }
    }
}
