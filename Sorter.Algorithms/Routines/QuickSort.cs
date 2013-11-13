using System;
using System.Threading.Tasks;
using Sorter.Timer;

namespace Sorter.Algorithms.Routines
{
    public sealed class QuickSort : SortRoutine
    {
        public QuickSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data)
        {
            throw new NotImplementedException();
        }
    }
}
