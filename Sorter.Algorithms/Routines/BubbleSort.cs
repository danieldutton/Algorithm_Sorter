using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter.Algorithms.Routines
{
    public sealed class BubbleSort : SortRoutine
    {
        public override async Task<int[]> SortAsync(int[] data)
        {
            OnStarted();

            await Task.Run(() =>
                {
                    for (int write = 0; write < data.Length; write++)
                    {
                        for (int sort = 0; sort < data.Length - 1; sort++)
                        {
                            if (data[sort] > data[sort + 1])
                            {
                                int temp = data[sort + 1];
                                data[sort + 1] = data[sort];
                                data[sort] = temp;
                            }
                        }
                    }
                });
            

            OnCompleted();
            MessageBox.Show("Bubble Sort Completed");
            return data;
        }
    }
}
