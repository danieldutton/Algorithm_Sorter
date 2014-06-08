using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class RadixSortLSD : SortRoutine
    {
        public RadixSortLSD(ITimer timer) 
            : base(timer)
        {
        }

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
            {
                int[] tempArr = new int[data.Length];
 
                const int bitsPerGroup = 4; // try to set this also to 2, 8 or 16 to see if it is quicker or not 
 
                const int bitsInAnInt32 = 32;

                int[] count = new int[1 << bitsPerGroup];
                int[] pref = new int[1 << bitsPerGroup];

                int groups = (int)Math.Ceiling((double)bitsInAnInt32 / bitsPerGroup);

                const int mask = (1 << bitsPerGroup) - 1;

                for (int c = 0, shift = 0; c < groups; c++, shift += bitsPerGroup)
                {
                    if (cancelToken.IsCancellationRequested)
                    {
                        OnCancelled();
                        return;
                    }

                    // reset count array 
                    for (int j = 0; j < count.Length; j++)
                        count[j] = 0;

                    // counting elements of the c-th group 
                    for (int i = 0; i < data.Length; i++)
                        count[(data[i] >> shift) & mask]++;

                    // calculating prefixes 
                    pref[0] = 0;
                    for (int i = 1; i < count.Length; i++)
                        pref[i] = pref[i - 1] + count[i - 1];

                    // from a[] to t[] elements ordered by c-th group 
                    for (int i = 0; i < data.Length; i++)
                        tempArr[pref[(data[i] >> shift) & mask]++] = data[i];

                    // a[]=t[] and start again until the last group 
                    tempArr.CopyTo(data, 0);
                }
            }, cancelToken);

            Timer.StopTimer();

            OnComplete(new SortFinishedEventArg(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
