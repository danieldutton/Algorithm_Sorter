using Sorter.Algorithms.Routines;
using System;
using System.Threading;
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

        public async Task<int[]> SortAsync(int[] dataToSort, CancellationToken cancellationToken)
        {
            if(dataToSort == null) 
                throw new ArgumentNullException("dataToSort");
            
            if(dataToSort.Length == 1) 
                throw new ArgumentOutOfRangeException("dataToSort");
            
            int[] result = await _sortRoutine.SortAsync(dataToSort, cancellationToken);

            return result;
        }

    }
}
