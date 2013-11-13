using System.Threading.Tasks;
using Sorter.Algorithms.EventArg;
using Sorter.Timer;

namespace Sorter.Algorithms.Routines
{
    public sealed class HeapSort : SortRoutine
    {
        public HeapSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data)
        {
            OnStarted();

            await Task.Run(() =>
                {
                    for (int i = (data.Length - 1) / 2; i >= 0; i--)
                        Adjust(data, i, data.Length - 1);

                    for (int i = data.Length - 1; i >= 1; i--)
                    {
                        int temp = data[0];
                        data[0] = data[i];
                        data[i] = temp;
                        Adjust(data, 0, i - 1);
                    }
                });

            OnCompleted(new SortingCompleteEventArgs(Timer.StartTime, Timer.StopTime, Timer.ElapsedTime));

            return data;
        }

        private void Adjust(int[] list, int i, int len)
        {
            int temp = list[i];
            int j = i * 2 + 1;

            while (j <= len)
            {
                if (j < len)
                    if (list[j].CompareTo(list[j + 1]) < 0)
                        j = j + 1;

                if (temp.CompareTo(list[j]) < 0)
                {
                    list[i] = list[j];
                    i = j;
                    j = 2 * i + 1;
                }
                else
                {
                    j = len + 1;
                }
            }
            list[i] = temp;
        }
    }
}
