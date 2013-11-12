using System;

namespace Sorter.Algorithms.Routines
{
    public sealed class InsertionSort : SortRoutine
    {
        public override int[] Sort(int[] data)
        {
            for (int j = 0; j < data.Length; j++)
            {
                int key = data[j];

                int i = j - 1;

                while (i >= 0 && data[i] > key)
                {
                    data[i + 1] = data[i];

                    i = i - 1;
                }

                data[i + 1] = key;
            }

            return data;
        }
    }
}
