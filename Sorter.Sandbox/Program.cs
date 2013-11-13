using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorter.Algorithms.Routines;
using Sorter.Timer;

namespace Sorter.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = new[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] actual = DoIt(test).Result; 
            Console.ReadLine();
        }
        
        public static async Task<int[]> DoIt(int[] test)
        {
            ITimer timer = new StopWatch();
            var sut = new ShellSort(timer);
            
            int[] result = await sut.SortAsync(test);
            return result;
        }
    }
}
