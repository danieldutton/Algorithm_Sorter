using System.Threading;
using Sorter.Algorithms.EventArg;
using Sorter.Utilities._Stopwatch;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class ShellSort : SortRoutine
    {
        public ShellSort(IStopwatch stopwatch) : base(stopwatch)
        {
        }

        public async override Task<int[]> SortAsync(int[] data, CancellationToken cancellationToken)
        {
            OnStarted();
            Stopwatch.Start();

            await Task.Run(() =>
                {
                    int i, j, increment, temp, x = data.Length;

                    increment = 3;

                    while (increment > 0)
                    {
                        if (cancellationToken.IsCancellationRequested)
                            return;

                        for (i = 0; i < x; i++)
                        {
                            j = i;
                            temp = data[i];

                            while ((j >= increment) && (data[j - increment] > temp))
                            {
                                data[j] = data[j - increment];
                                j = j - increment;
                            }

                            data[j] = temp;
                        }

                        if (increment / 2 != 0)
                        {
                            increment = increment / 2;
                        }
                        else if (increment == 1)
                        {
                            increment = 0;
                        }
                        else
                        {
                            increment = 1;
                        }
                    }
                }, cancellationToken);

            Stopwatch.Stop();
            
            OnCompleted(new SortCompleteEventArgs(Stopwatch.ElapsedMilliseconds, data.Length));
            
            return data;
        }
    }
}
