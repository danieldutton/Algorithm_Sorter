using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using Sorter.Algorithms.Routines;

namespace Sorter.Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom("Sorter.Algorithms.dll");
            var result = assembly.GetTypes().Where(x => x.IsSubclassOf((typeof (SortRoutine))));

            List<string> classNames = new List<string>();
            foreach (var className in result)
            {
                classNames.Add(className.Name);
            }

            foreach (var className in classNames)
            {
                Console.WriteLine(className);
            }
            Console.ReadLine();
        }  
    }
}
