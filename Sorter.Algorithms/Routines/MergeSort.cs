namespace Sorter.Algorithms.Routines
{
    public sealed class MergeSort : SortRoutine
    {
        public override int[] Sort(int[] data)
        {
            OnStarted();

            if (data.Length == 1)
            {
                OnCompleted();
                return data;   
            }
                            
            int middle = data.Length / 2;
            int[] left = new int[middle];
            
            for (int i = 0; i < middle; i++)
            {
                left[i] = data[i];
            }
            
            int[] right = new int[data.Length - middle];
            
            for (int i = 0; i < data.Length - middle; i++)
            {
                right[i] = data[i + middle];
            }
            
            left = Sort(left);
            right = Sort(right);

            int leftptr = 0;
            int rightptr = 0;

            int[] sorted = new int[data.Length];
            
            for (int k = 0; k < data.Length; k++)
            {
                if (rightptr == right.Length || ((leftptr < left.Length) && (left[leftptr] <= right[rightptr])))
                {
                    sorted[k] = left[leftptr];
                    leftptr++;
                }
                else if (leftptr == left.Length || ((rightptr < right.Length) && (right[rightptr] <= left[leftptr])))
                {
                    sorted[k] = right[rightptr];
                    rightptr++;
                }
            }

            OnCompleted();

            return sorted;
        }
    }
}
