﻿using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public sealed class SelectionSort : SortRoutine
    {
        public SelectionSort(ITimer timer) 
            : base(timer){}

        public override async Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();           
            Timer.StartTimer();
           
            await Task.Run(() =>
                {
                    int i, j;
                    int min, temp;

                    for (i = 0; i < data.Length - 1; i++)
                    {
                        if (cancelToken.IsCancellationRequested)
                        {
                            OnCancelled();
                            return;
                        }
                        
                        min = i;
                        for (j = i + 1; j < data.Length; j++)
                        {
                            if (data[j] < data[min])
                                min = j;
                        }
                        temp = data[i];
                        data[i] = data[min];
                        data[min] = temp;
                    }
                }, cancelToken);

            Timer.StopTimer();

            OnComplete(new SortCompleteEventArgs(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
