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

        public int[] Sort(int[] dataToSort)
        {
            return _sortRoutine.Sort(dataToSort);
        }
    }
}
