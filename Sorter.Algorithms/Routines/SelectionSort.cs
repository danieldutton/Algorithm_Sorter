using Sorter.Algorithms.EventArg;
using Sorter.Utilities._Timer;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class SelectionSort : SortRoutine
    {
        public SelectionSort(IStopwatch stopwatch) : base(stopwatch){}

        public override async Task<int[]> SortAsync(int[] data)
        {
            OnStarted();           
            Stopwatch.Start();
           
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
            
            Stopwatch.Start();
            
            OnCompleted(new SortCompleteEventArgs(Stopwatch.ElapsedMilliseconds, data.Length));

            return data;
        }
    }
}
