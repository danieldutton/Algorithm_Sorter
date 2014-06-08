using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class CycleSort : SortRoutine
    {
        public CycleSort(ITimer timer) 
            : base(timer)
        {
        }

        public async override Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();

            Timer.StartTimer();

            await Task.Run(() =>
                {
                    int writes = 0;
                    for (int cycleStart = 0; cycleStart < data.Length; cycleStart++)
                    {
                        int item = data[cycleStart];
                        int pos = cycleStart;

                        do
                        {
                            int to = 0;
                            for (int i = 0; i < data.Length; i++)
                            {
                                if (cancelToken.IsCancellationRequested)
                                {
                                    OnCancelled();
                                    return;
                                }

                                if (i != cycleStart && ((IComparable)data[i]).CompareTo(item) < 0)
                                {
                                    to++;
                                }
                            }
                            if (pos != to)
                            {
                                while (pos != to && ((IComparable)item).CompareTo(data[to]) == 0)
                                {
                                    to++;
                                }

                                int temp = data[to];
                                data[to] = item;

                                item = temp;

                                writes++;
                                pos = to;
                            }
                        } while (cycleStart != pos);
                    }                   
                }, cancelToken);

            Timer.StopTimer();
            OnComplete(new SortFinishedEventArg(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
