using Sorter.Algorithms.EventArg;
using Sorter.Utilities._Stopwatch;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public class CocktailShakerSort : SortRoutine 
    {
        public CocktailShakerSort(IStopwatch stopWatch) : base(stopWatch)
        {
        }

        public async override Task<int[]> SortAsync(int[] data, CancellationToken cancellationToken)
        {
            OnStarted();
            Stopwatch.Start();

            await Task.Run(() =>
                {
                    bool swapped;
                    do
                    {
                        if (cancellationToken.IsCancellationRequested)
                            return;

                        swapped = false;
                        for (int i = 0; i <= data.Length - 2; i++)
                        {
                            if (data[i] > data[i + 1])
                            {
                                int temp = data[i];
                                data[i] = data[i + 1];
                                data[i + 1] = temp;
                                swapped = true;
                            }
                        }
                        if (!swapped)
                        {
                            // exit the outer loop here if no swaps occurred.
                            break;
                        }
                        swapped = false;
                        for (int i = data.Length - 2; i >= 0; i--)
                        {
                            if (data[i] > data[i + 1])
                            {
                                int temp = data[i];
                                data[i] = data[i + 1];
                                data[i + 1] = temp;
                                swapped = true;
                            }
                        }
                    } while (swapped);

                    Stopwatch.Stop();
                }, cancellationToken);

            OnCompleted(new SortCompleteEventArgs(Stopwatch.ElapsedMilliseconds, data.Length, cancellationToken.IsCancellationRequested));

            return data;
        }
    }
}
