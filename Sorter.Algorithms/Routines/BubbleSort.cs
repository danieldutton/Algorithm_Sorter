using Sorter.Algorithms.EventArg;
using Sorter.Utilities._Stopwatch;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class BubbleSort : SortRoutine
    {
        public BubbleSort(IStopwatch stopwatch) : base(stopwatch)
        {
        }

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Stopwatch.Start();

            await Task.Run(() =>
                {
                    for (int write = 0; write < data.Length; write++)
                    {
                        if (cancelToken.IsCancellationRequested)
                            return;

                        for (int sort = 0; sort < data.Length - 1; sort++)
                        {
                            if (data[sort] > data[sort + 1])
                            {
                                int temp = data[sort + 1];
                                data[sort + 1] = data[sort];
                                data[sort] = temp;
                            }
                        }
                    }
                }, cancelToken);

            Stopwatch.Stop();
            
            OnCompleted(new SortCompleteEventArgs(Stopwatch.ElapsedMilliseconds, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
