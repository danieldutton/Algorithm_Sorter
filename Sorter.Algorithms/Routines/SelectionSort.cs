using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sorter.Algorithms.EventArg;
using Sorter.Timer;

namespace Sorter.Algorithms.Routines
{
    public sealed class SelectionSort : SortRoutine
    {
        public SelectionSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data)
        {
            OnStarted();
            Timer.Start();
            await Task.Run(() =>
                {
                    for (int i = 0; i < data.Length - 1; i++)
                    {
                        int min = i;
                        int j;
                        for (j = i + 1; j < data.Length; j++)
                        {
                            if (data[j] < data[min])
                                min = j;
                        }
                        int temp = data[i];
                        data[i] = data[min];
                        data[min] = temp;
                    }
                });
            Timer.Stop();
            OnCompleted(new SortingCompleteEventArgs(Timer.StartTime, Timer.StopTime, Timer.ElapsedTime));
            MessageBox.Show("Selection Sort Finished" + " Time:" + Timer.ElapsedTime);
            return data;
        }
    }
}
