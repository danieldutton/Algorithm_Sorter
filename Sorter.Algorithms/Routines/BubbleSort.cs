namespace Sorter.Algorithms.Routines
{
    public sealed class BubbleSort : SortRoutine
    {
        public override int[] Sort(int[] data)
        {
            OnStarted();

            int temp = 0;

            for (int write = 0; write < data.Length; write++)
            {
                for (int sort = 0; sort < data.Length - 1; sort++)
                {
                    if (data[sort] > data[sort + 1])
                    {
                        temp = data[sort + 1];
                        data[sort + 1] = data[sort];
                        data[sort] = temp;
                    }
                }
            }

            OnCompleted();

            return data;
        }
    }
}
