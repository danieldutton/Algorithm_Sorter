using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorter.Algorithms.Routines;
using Sorter.Timer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            DoIt();
            Console.ReadLine();
        }

        public static async void DoIt()
        {
            var timer = new StopWatch();
            var sut = new SelectionSort(timer);
            int[] unsorted = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] sorted = new[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            int[] result = await sut.SortAsync(unsorted);
            bool isTrue = sorted.SequenceEqual(result);
        }
    }
}
