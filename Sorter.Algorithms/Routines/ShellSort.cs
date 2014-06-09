using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class ShellSort : SortRoutine
    {
        public ShellSort(ITimer timer) 
            : base(timer)
        {
        }

        public async override Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
                {
                    int i, j, increment, temp, x = data.Length;

                    increment = 3;

                    while (increment > 0)
                    {
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

                            if (cancelToken.IsCancellationRequested)
                            {
                                OnCancelled();
                                return;
                            }
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
                }, cancelToken);

            Timer.StopTimer();

            OnComplete(new SortCompleteEventArgs(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));
            
            return data;
        }
    }
}
