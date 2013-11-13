using System;
using Sorter.Algorithms.EventArg;
using Sorter.Timer;
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
            OnStarted();
            Timer.Start();
            int[] result = null;
           
            //await Task.Run(() =>
            //    {
            //        result = MSort(data);
            //    });

            Timer.Stop();
            OnCompleted(new SortCompleteEventArgs(Timer.StartTime, Timer.StopTime, Timer.ElapsedTime));

            return result;
        }

        public int[] MergeSortAction(int[] input)
        {
            int inputArrayLength = input.Length;

            if (inputArrayLength.Equals(1))
            {
                return input;
            }

            int middle = inputArrayLength / 2;
            int[] left = new int[middle];
            int[] right = new int[inputArrayLength - middle];

            //for (int i = 0; i < middle; i++)
            //{
            //    left[i] = input[i];
            //}

            //for (int i = 0; i < inputArrayLength - middle; i++)
            //{
            //    right[i] = input[i + middle];
            //}

            Array.Copy(input, 0, left, 0, middle);
            Array.Copy(input, middle, right, 0, inputArrayLength - middle);

            left = MergeSortAction(left);
            right = MergeSortAction(right);

            int[] sortedArray = new int[inputArrayLength];
            int leftp = 0;
            int rightp = 0;

            for (int count = 0; count < inputArrayLength; count++)
            {
                if (rightp == right.Length || (leftp < left.Length && left[leftp] <= right[rightp]))
                {
                    sortedArray[count] = left[leftp];
                    leftp++;
                }
                else if (leftp == left.Length || (rightp < right.Length && right[rightp] <= left[leftp]))
                {
                    sortedArray[count] = right[rightp];
                    rightp++;
                }
            }

            return sortedArray;
        }
    }
}
