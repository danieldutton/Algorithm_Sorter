using System.Threading;
using System.Threading.Tasks;
using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;

namespace Sorter.Algorithms.Routines
{
    public sealed class CountingSort : SortRoutine
    {
        public CountingSort(ITimer timer) 
            : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
            {
                int[] aux = new int[data.Length];

                int min = data[0];
                int max = data[0];

                for (int i = 1; i < data.Length; i++)
                {
                    if (data[i] < min) min = data[i];

                    else if (data[i] > max) max = data[i];
                }

                int[] counts = new int[max - min + 1];

                for (int i = 0; i < data.Length; i++)
                {
                    counts[data[i] - min]++;
                }

                if (cancelToken.IsCancellationRequested)
                {
                    OnCancelled();
                    return;
                }

                counts[0]--;

                for (int i = 1; i < counts.Length; i++)
                {
                    counts[i] = counts[i] + counts[i - 1];
                }

                for (int i = data.Length - 1; i >= 0; i--)
                {
                    aux[counts[data[i] - min]--] = data[i];
                }

                data = aux;
            }, cancelToken);

            Timer.StopTimer();

            OnComplete(new SortFinishedEventArg(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}