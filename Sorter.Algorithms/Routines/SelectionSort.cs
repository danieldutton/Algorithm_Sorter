﻿namespace Sorter.Algorithms.Routines
{
    public sealed class SelectionSort : SortRoutine
    {
        public override int[] Sort(int[] data)
        {
            OnStarted();

            int i, j;
            int min, temp;

            for (i = 0; i < data.Length - 1; i++)
            {
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

            OnCompleted();
            
            return data;
        }
    }
}
