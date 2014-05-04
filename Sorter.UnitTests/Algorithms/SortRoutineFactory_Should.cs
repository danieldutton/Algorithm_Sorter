using NUnit.Framework;
using Sorter.Algorithms;
using Sorter.Algorithms.Routines;

namespace Sorter.UnitTests.Algorithms
{
    [TestFixture]
    public class SortRoutineFactory_Should
    {
        [Test]
        public void CreateSortRoutine_ReturnNull_IfSortRoutineNotFound()
        {
            SortRoutine sortRoutine = SortRoutineFactory.CreateSortRoutine("test");

            Assert.IsNull(sortRoutine);
        }

        [Test]
        public void CreateSortRoutine_ReturnANew_BubbleSort()
        {
            var bubbleSort = SortRoutineFactory.CreateSortRoutine("BubbleSort") 
                as BubbleSort;

            Assert.IsInstanceOf<BubbleSort>(bubbleSort);
        }

        [Test]
        public void CreateSortRoutine_ReturnANew_CocktailShakerSort()
        {
            var cocktailShakerSort = SortRoutineFactory.CreateSortRoutine("CocktailShakerSort") 
                as CocktailShakerSort;

            Assert.IsInstanceOf<CocktailShakerSort>(cocktailShakerSort);
        }

        [Test]
        public void CreateSortRoutine_ReturnANew_CycleSort()
        {
            var cycleSort = SortRoutineFactory.CreateSortRoutine("CycleSort") 
                as CycleSort;

            Assert.IsInstanceOf<CycleSort>(cycleSort);
        }

        [Test]
        public void CreateSortRoutine_ReturnANew_GnomeSort()
        {
            var gnomeSort = SortRoutineFactory.CreateSortRoutine("GnomeSort") 
                as GnomeSort;

            Assert.IsInstanceOf<GnomeSort>(gnomeSort);
        }

        [Test]
        public void CreateSortRoutine_ReturnANew_HeapSort()
        {
            var heapSort = SortRoutineFactory.CreateSortRoutine("HeapSort") 
                as HeapSort;

            Assert.IsInstanceOf<HeapSort>(heapSort);
        }

        [Test]
        public void CreateSortRoutine_ReturnANew_InsertionSort()
        {
            var insertionSort = SortRoutineFactory.CreateSortRoutine("InsertionSort") 
                as InsertionSort;

            Assert.IsInstanceOf<InsertionSort>(insertionSort);
        }

        [Test]
        public void CreateSortRoutine_ReturnANew_QuickSort()
        {
            var quickSort = SortRoutineFactory.CreateSortRoutine("QuickSort") 
                as QuickSort;

            Assert.IsInstanceOf<QuickSort>(quickSort);
        }

        [Test]
        public void CreateSortRoutine_ReturnANew_SelectionSort()
        {
            var selectionSort = SortRoutineFactory.CreateSortRoutine("SelectionSort") 
                as SelectionSort;

            Assert.IsInstanceOf<SelectionSort>(selectionSort);
        }

        [Test]
        public void CreateSortRoutine_ReturnANew_ShellSort()
        {
            var shellSort = SortRoutineFactory.CreateSortRoutine("ShellSort") 
                as ShellSort;

            Assert.IsInstanceOf<ShellSort>(shellSort);
        }
    }
}
