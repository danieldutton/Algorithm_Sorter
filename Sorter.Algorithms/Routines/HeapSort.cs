using System.Threading;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Utilities._Stopwatch;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class HeapSort : SortRoutine, ISwappable
    {
        public HeapSort(IStopwatch stopwatch) : base(stopwatch)
        {
        }

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancellationToken)
        {
            OnStarted();
            Stopwatch.Start();

            await Task.Run(() =>
                {
                    for (int i = (data.Length - 1)/2; i >= 0; i--)
                    {
                        if (cancellationToken.IsCancellationRequested)
                            return;
                        
                        Swap(data, i, data.Length - 1);    
                    }
                        

                    for (int i = data.Length - 1; i >= 1; i--)
                    {
                        int temp = data[0];
                        data[0] = data[i];
                        data[i] = temp;
                        Swap(data, 0, i - 1);
                    }
                }, cancellationToken);

            OnCompleted(new SortCompleteEventArgs(Stopwatch.ElapsedMilliseconds, data.Length));
            
            Stopwatch.Stop();

            return data;
        }


        public int[] Swap(int[] data, int left, int right)
        {
            int temp = data[left];
            int j = left * 2 + 1;

            while (j <= right)
            {
                if (j < right)
                    if (data[j].CompareTo(data[j + 1]) < 0)
                        j = j + 1;

                if (temp.CompareTo(data[j]) < 0)
                {
                    data[left] = data[j];
                    left = j;
                    j = 2 * left + 1;
                }
                else
                {
                    j = right + 1;
                }
            }
            data[left] = temp;
            return data;
        }
    }
}
