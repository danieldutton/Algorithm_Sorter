using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class InsertionSort : SortRoutine
    {
        public InsertionSort(ITimer timer) 
            : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
                {
                    for (int j = 0; j < data.Length; j++)
                    {
                        if (cancelToken.IsCancellationRequested)
                        {
                            OnCancelled();
                            return;
                        }

                        int key = data[j];

                        int i = j - 1;

                        while (i >= 0 && data[i] > key)
                        {
                            data[i + 1] = data[i];

                            i = i - 1;
                        }

                        data[i + 1] = key;
                    }
                }, cancelToken);

            Timer.StopTimer();

            OnComplete(new SortCompleteEventArgs(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
