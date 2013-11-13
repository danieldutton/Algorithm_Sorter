using Sorter.Algorithms.EventArg;
using Sorter.Timer;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public class ShellSort : SortRoutine
    {
        public ShellSort(ITimer timer) : base(timer)
        {
        }

        public async override Task<int[]> SortAsync(int[] data)
        {
            OnStarted();
            Timer.Start();

            await Task.Run(() =>
                {
                    int i, j, increment, temp, x = 0;

                    increment = 3;

                    while (increment > 0)
                    {
                        for (i = 0; i < x; i++)
                        {
                            j = i;
                            temp = data[i];

                            while ((j >= increment) && (data[j - increment] > temp))
                            {
                                data[j] = data[j - increment];
                                j = j - increment;
                            }

                            data[j] = temp;
                        }

                        if (increment / 2 != 0)
                        {
                            increment = increment / 2;
                        }
                        else if (increment == 1)
                        {
                            increment = 0;
                        }
                        else
                        {
                            increment = 1;
                        }
                    }
                });

            Timer.Stop();
            OnCompleted(new SortCompleteEventArgs(Timer.StartTime, Timer.StopTime, Timer.ElapsedTime));
            return data;
        }
    }
}
