using Sorter.Algorithms.EventArg;
using Sorter.Timer;
using System;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class MergeSort : SortRoutine
    {
        public MergeSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data)
        {
            //OnStarted();
            //Timer.Start();

            //int[] sorted = null;

            //await Task.Run(() =>
            //    {
            //        int middle = data.Length / 2;
            //        int[] left = new int[middle];

            //        for (int i = 0; i < middle; i++)
            //        {
            //            left[i] = data[i];
            //        }

            //        int[] right = new int[data.Length - middle];

            //        for (int i = 0; i < data.Length - middle; i++)
            //        {
            //            right[i] = data[i + middle];
            //        }

            //        left = SortAsync(left);
            //        right = SortAsync(right);

            //        int leftptr = 0;
            //        int rightptr = 0;

            //        sorted = new int[data.Length];

            //        for (int k = 0; k < data.Length; k++)
            //        {
            //            if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
            //            {
            //                sorted[k] = left[leftptr];
            //                leftptr++;
            //            }
            //            else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
            //            {
            //                sorted[k] = right[rightptr];
            //                rightptr++;
            //            }
            //        }
            //    });

            //Timer.Stop();
            //OnCompleted(new SortCompleteEventArgs(Timer.StartTime, Timer.StopTime, Timer.ElapsedTime));

            //return sorted;
            throw new NotImplementedException();

        }
    }
}
