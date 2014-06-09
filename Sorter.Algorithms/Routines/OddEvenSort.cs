using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Utilities.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public class OddEvenSort : SortRoutine, ISwappable
    {
        public OddEvenSort(ITimer timer) 
            : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
            {
                var sorted = false;
                while (!sorted)
                {
                    sorted = true;
                    for (var i = 1; i < data.Length - 1; i += 2)
                    {
                        if (cancelToken.IsCancellationRequested)
                        {
                            OnCancelled();
                            return;
                        }

                        if (data[i] > data[i + 1])
                        {
                            Swap(data, i, i + 1);
                            sorted = false;
                        }
                    }

                    for (var i = 0; i < data.Length - 1; i += 2)
                    {
                        if (data[i] > data[i + 1])
                        {
                            Swap(data, i, i + 1);
                            sorted = false;
                        }
                    }
                }
            }, cancelToken);

            Timer.StopTimer();

            OnComplete(new SortCompleteEventArgs(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));


            return data;
        }

        public int[] Swap(int[] data, int left, int right)
        {
            int temp = data[left];
            data[left] = data[right];
            data[right] = temp;

            return data;
        }
    }
}
