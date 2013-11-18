using Sorter.Algorithms.EventArg;
using Sorter.Utilities._Stopwatch;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public class GnomeSort : SortRoutine
    {
        public GnomeSort(IStopwatch stopWatch) : base(stopWatch)
        {
        }

        public async override Task<int[]> SortAsync(int[] data, CancellationToken cancellationToken)
        {
            OnStarted();
            Stopwatch.Start();

            await Task.Run(() =>
                {
                    int i = 1;
                    int j = 2;

                    while (i < data.Length)
                    {
                        if (cancellationToken.IsCancellationRequested)
                            return;

                        if (data[i - 1] <= data[i])
                        {
                            i = j;
                            j++;
                        }
                        else
                        {
                            int tmp = data[i - 1];
                            data[i - 1] = data[i];
                            data[i] = tmp;
                            i -= 1;
                            if (i == 0)
                            {
                                i = 1;
                                j = 2;
                            }
                        }
                    }
                }, cancellationToken);

            Stopwatch.Stop();

            OnCompleted(new SortCompleteEventArgs(Stopwatch.ElapsedMilliseconds, data.Length, cancellationToken.IsCancellationRequested));

            return data;
        }
    }
}
