using Sorter.Algorithms.EventArg;
using Sorter.Utilities._Stopwatch;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public class CycleSort : SortRoutine
    {
        public CycleSort(IStopwatch stopWatch) : base(stopWatch)
        {
        }

        public async override Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();

            Stopwatch.Start();

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

            Stopwatch.Stop();
            OnCompleted(new SortCompleteEventArgs(Stopwatch.ElapsedMilliseconds, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
