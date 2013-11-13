using System.Threading.Tasks;
using Sorter.Algorithms.EventArg;
using Sorter.Timer;

namespace Sorter.Algorithms.Routines
{
    public sealed class InsertionSort : SortRoutine
    {
        public InsertionSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data)
        {
            OnStarted();

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

            OnCompleted(new SortingCompleteEventArgs(Timer.StartTime, Timer.StopTime, Timer.ElapsedTime));

            return data;
        }
    }
}
