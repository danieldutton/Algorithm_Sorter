using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class PigeonHoleSort : SortRoutine
    {
        public PigeonHoleSort(ITimer timer) : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
            {
                // size of range of values in the list (ie, number of pigeonholes we need)
                int min = data[0], max = data[0];
                foreach (int x in data)
                {
                    min = Math.Min(x, min);
                    max = Math.Max(x, max);
                }
                int size = max - min + 1;

                // our array of pigeonholes
                long[] holes = new long[size];

                // Populate the pigeonholes.
                foreach (int x in data)
                    holes[x - min]++;

                int i = 0;

                if (cancelToken.IsCancellationRequested)
                {
                    OnCancelled();
                    return; //OnCancelled not firing
                }

                for (int count = 0; count < size; count++)
                {
                    
                    while (holes[count]-- > 0)
                        data[i++] = count + min;
                }
                    
            }, cancelToken);

            Timer.StopTimer();

            OnComplete(new SortCompleteEventArgs(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}