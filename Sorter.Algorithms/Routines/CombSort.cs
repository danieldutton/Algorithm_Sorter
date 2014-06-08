using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class CombSort : SortRoutine
    {
        public CombSort(ITimer timer) 
            : base(timer)
        {
        }

        public async override Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
            {
                double gap = data.Length;
                bool swaps = true;
                while (gap > 1 || swaps)
                {
                    gap /= 1.247330950103979;
                    if (gap < 1) { gap = 1; }
                    int i = 0;
                    swaps = false;
                    while (i + gap < data.Length)
                    {
                        if (cancelToken.IsCancellationRequested)
                        {
                            OnCancelled();
                            return;
                        }

                        int igap = i + (int)gap;
                        if (data[i] > data[igap])
                        {
                            int swap = data[i];
                            data[i] = data[igap];
                            data[igap] = swap;
                            swaps = true;
                        }
                        i++;
                    }
                }
            }, cancelToken);
            
            Timer.StopTimer();

            OnComplete(new SortFinishedEventArg(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
