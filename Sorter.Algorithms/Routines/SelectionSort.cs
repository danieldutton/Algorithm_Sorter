using Sorter.Algorithms.EventArg;
using Sorter.Utilities._Stopwatch;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class SelectionSort : SortRoutine
    {
        public SelectionSort(IStopwatch stopwatch) : base(stopwatch){}

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();           
            Stopwatch.Start();
           
            await Task.Run(() =>
                {
                    int i, j;
                    int min, temp;

                    for (i = 0; i < data.Length - 1; i++)
                    {
                        if (cancelToken.IsCancellationRequested)
                        {
                            OnCancelled();
                            return;
                        }
                        
                        min = i;
                        for (j = i + 1; j < data.Length; j++)
                        {
                            if (data[j] < data[min])
                                min = j;
                        }
                        temp = data[i];
                        data[i] = data[min];
                        data[min] = temp;
                    }
                }, cancelToken);

            Stopwatch.Stop();

            OnCompleted(new SortCompleteEventArgs(Stopwatch.ElapsedMilliseconds, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
