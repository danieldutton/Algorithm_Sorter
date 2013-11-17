using Sorter.Algorithms.EventArg;
using Sorter.Utilities._Stopwatch;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class InsertionSort : SortRoutine
    {
        public InsertionSort(IStopwatch stopwatch) : base(stopwatch)
        {
        }

        public override async Task<int[]> SortAsync(int[] data)
        {
            OnStarted();
            Stopwatch.Start();

            await Task.Run(() =>
                {
                    for (int j = 0; j < data.Length; j++)
                    {
                        int key = data[j];

                        int i = j - 1;

                        while (i >= 0 && data[i] > key)
                        {
                            data[i + 1] = data[i];

                            i = i - 1;
                        }

                        data[i + 1] = key;
                    }
                });

            Stopwatch.Stop();
            OnCompleted(new SortCompleteEventArgs(Stopwatch.ElapsedMilliseconds, data.Length));

            return data;
        }
    }
}
