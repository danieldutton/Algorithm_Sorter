using Sorter.Algorithms.EventArg;
using Sorter.Timer;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class BubbleSort : SortRoutine
    {
        public BubbleSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data)
        {
            OnStarted();
            Timer.Start();

            await Task.Run(() =>
                {
                    for (int write = 0; write < data.Length; write++)
                    {
                        for (int sort = 0; sort < data.Length - 1; sort++)
                        {
                            if (data[sort] > data[sort + 1])
                            {
                                int temp = data[sort + 1];
                                data[sort + 1] = data[sort];
                                data[sort] = temp;
                            }
                        }
                    }
                });

            Timer.Stop();
            
            OnCompleted(new SortingCompleteEventArgs(Timer.StartTime, Timer.StopTime, Timer.ElapsedTime));

            return data;
        }
    }
}
