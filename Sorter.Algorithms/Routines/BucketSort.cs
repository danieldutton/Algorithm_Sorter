using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class BucketSort : SortRoutine
    {
        public BucketSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
            {
                //Find the maximum and minimum values in the array
                int maxValue = data[0]; //start with first element
                int minValue = data[0];

                //Note: start from index 1
                for (int i = 1; i < data.Length; i++)
                {
                    if (data[i] > maxValue)
                        maxValue = data[i];

                    if (data[i] < minValue)
                        minValue = data[i];
                }

                //Create a temporary "bucket" to store the values in order
                var bucket = new List<int>[maxValue - minValue + 1];

                //Initialize the bucket
                for (int i = 0; i < bucket.Length; i++)
                {
                    bucket[i] = new List<int>();
                }

                for (int i = 0; i < data.Length; i++)
                {
                    bucket[data[i] - minValue].Add(data[i]);
                }

                int k = 0; //index for original array
                for (int i = 0; i < bucket.Length; i++)
                {
                    if (cancelToken.IsCancellationRequested)
                    {
                        OnCancelled();
                        return;
                    }

                    if (bucket[i].Count > 0)
                    {
                        for (int j = 0; j < bucket[i].Count; j++)
                        {
                            data[k] = bucket[i][j];
                            k++;
                        }
                    }
                }
            }, cancelToken);
            Timer.StopTimer();

            OnComplete(new SortFinishedEventArg(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
