using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Utilities.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class MergeSort : SortRoutine, ISwappable
    {
        private CancellationToken _cancellationToken;


        public MergeSort(ITimer timer) 
            : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            _cancellationToken = cancelToken;

            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
            {
                Swap(data, 0, data.Length - 1);
            }, cancelToken);

            Timer.StopTimer();

            OnComplete(new SortFinishedEventArg(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }

        public int[] Swap(int[] data, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Swap(data, left, middle);
                Swap(data, middle + 1, right);

                int[] leftArray = new int[middle - left + 1];
                int[] rightArray = new int[right - middle];

                Array.Copy(data, left, leftArray, 0, middle - left + 1);
                Array.Copy(data, middle + 1, rightArray, 0, right - middle);

                int i = 0;
                int j = 0;
                for (int k = left; k < right + 1; k++)
                {
                    if (_cancellationToken.IsCancellationRequested)
                    {
                        OnCancelled();
                        return new []{0};
                    }

                    if (i == leftArray.Length)
                    {
                        data[k] = rightArray[j];
                        j++;
                    }
                    else if (j == rightArray.Length)
                    {
                        data[k] = leftArray[i];
                        i++;
                    }
                    else if (leftArray[i] <= rightArray[j])
                    {
                        data[k] = leftArray[i];
                        i++;
                    }
                    else
                    {
                        data[k] = rightArray[j];
                        j++;
                    }
                }
            }
            return data;
        }
    }
}
