using Sorter.Algorithms.Routines;
using Sorter.Utilities;

namespace Sorter.Algorithms
{
    public static class SortRoutineFactory
    {
        public static SortRoutine CreateSortRoutine(string name)
        {
            SortRoutine sortRoutine = null;

            switch (name)
            {
                case "BubbleSort": sortRoutine = new BubbleSort(new Timer());
                    break;
                case "CocktailShakerSort": sortRoutine = new CocktailShakerSort(new Timer());
                    break;
                case "CombSort": sortRoutine = new CombSort(new Timer());
                    break;
                case "CycleSort": sortRoutine = new CycleSort(new Timer());
                    break;
                case "GnomeSort": sortRoutine = new GnomeSort(new Timer());
                    break;
                case "HeapSort": sortRoutine = new HeapSort(new Timer());
                    break;
                case "InsertionSort": sortRoutine = new InsertionSort(new Timer());
                    break;
                case "MergeSort": sortRoutine = new MergeSort(new Timer());
                    break;
                case "QuickSort": sortRoutine = new QuickSort(new Timer());
                    break;
                case "SelectionSort": sortRoutine = new SelectionSort(new Timer());
                    break;
                case "ShellSort": sortRoutine = new ShellSort(new Timer());
                    break;
            }
            return sortRoutine;
        }
    }
}
