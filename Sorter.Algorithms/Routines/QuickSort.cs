using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Timer;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class QuickSort : SortRoutine, ISwappable 
    {
        public QuickSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data)
        {
            OnStarted();
            Timer.Start();

            int[] result = null;

            await Task.Run(() => result = Swap(data, 0, data.Length - 1));

            Timer.Stop();
            OnCompleted(new SortCompleteEventArgs(Timer.StartTime, Timer.StopTime, Timer.ElapsedTime, data.Length));

            return result;
        }


        public int[] Swap(int[] data, int left, int right)
        {
            int pivot, l_hold, r_hold;

            l_hold = left;
            r_hold = right;
            pivot = data[left];

            while (left < right)
            {
                while ((data[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    data[left] = data[right];
                    left++;
                }

                while ((data[left] <= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    data[right] = data[left];
                    right--;
                }
            }

            data[left] = pivot;
            pivot = left;
            left = l_hold;
            right = r_hold;

            if (left < pivot)
            {
                Swap(data, left, pivot - 1);
            }

            if (right > pivot)
            {
                Swap(data, pivot + 1, right);
            }

            return data;
        }
    }
}
