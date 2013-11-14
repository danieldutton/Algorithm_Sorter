using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Interfaces;
using Sorter.Timer;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class HeapSort : SortRoutine, ISwappable
    {
        public HeapSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data)
        {
            OnStarted();
            Timer.Start();

            await Task.Run(() =>
                {
                    for (int i = (data.Length - 1) / 2; i >= 0; i--)
                        Swap(data, i, data.Length - 1);

                    for (int i = data.Length - 1; i >= 1; i--)
                    {
                        int temp = data[0];
                        data[0] = data[i];
                        data[i] = temp;
                        Swap(data, 0, i - 1);
                    }
                });

            OnCompleted(new SortCompleteEventArgs(Timer.StartTime, Timer.StopTime, Timer.ElapsedTime, data.Length));
            Timer.Stop();

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
