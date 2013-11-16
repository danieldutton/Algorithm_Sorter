using Sorter.Algorithms.EventArg;
using Sorter.Timer;
using System.Threading.Tasks;

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
            Timer.Start();

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

            Timer.Stop();
            OnCompleted(new SortCompleteEventArgs(Timer.StartTimeInMilliseconds, Timer.StopTimeInMilliseconds, Timer.ElapsedTimeInMilliseconds, data.Length));

            return data;
        }
    }
}
