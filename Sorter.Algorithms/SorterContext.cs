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

        public async Task<int[]> Sort(int[] dataToSort)
        {
            if(dataToSort == null) 
                throw new ArgumentNullException("dataToSort");
            
            if(dataToSort.Length == 1) 
                throw new ArgumentOutOfRangeException("dataToSort");
            int[] result = null;
            
            try
            {
                result = await _sortRoutine.SortAsync(dataToSort);
            }
            catch (Exception e)
            {
                
            }

            return result;
        }

    }
}
