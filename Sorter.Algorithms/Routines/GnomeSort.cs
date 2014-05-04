using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public class GnomeSort : SortRoutine
    {
        public GnomeSort(ITimer timer) : base(timer)
        {
        }

        public async override Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
                {
                    int i = 1;
                    int j = 2;

                    while (i < data.Length)
                    {
                        if (cancelToken.IsCancellationRequested)
                        {
                            OnCancelled();
                            return;
                        }

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
                }, cancelToken);

            Timer.StopTimer();

            OnComplete(new SortFinishedEventArg(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
