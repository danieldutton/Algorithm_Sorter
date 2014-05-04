using Sorter.Algorithms.EventArg;
using Sorter.Utilities.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.Algorithms.Routines
{
    public class CocktailShakerSort : SortRoutine 
    {
        public CocktailShakerSort(ITimer timer) : base(timer)
        {
        }

        public async override Task<int[]> SortAsync(int[] data, CancellationToken cancelToken)
        {
            OnStarted();
            Timer.StartTimer();

            await Task.Run(() =>
                {
                    bool swapped;
                    do
                    {
                        if (cancelToken.IsCancellationRequested)
                        {
                            OnCancelled();
                            return;
                        }

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

                    
                }, cancelToken);

            Timer.StopTimer();
            
            OnComplete(new SortFinishedEventArg(Timer.TimeElapsedMs, data.Length, cancelToken.IsCancellationRequested));

            return data;
        }
    }
}
