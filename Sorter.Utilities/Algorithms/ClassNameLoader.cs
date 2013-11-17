using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Sorter.Utilities.Algorithms
{
    public class ClassNameLoader : IClassNameLoader
    {
        public List<string> Load(string assemblyName, Type inheritsFrom)
        {
            if(string.IsNullOrWhiteSpace(assemblyName)) throw new ArgumentException();

            if(inheritsFrom == null) throw new ArgumentNullException();

            Assembly assembly = Assembly.LoadFrom(assemblyName);
            IEnumerable<Type> result = assembly.GetTypes().Where(x => x.IsSubclassOf(inheritsFrom));

            List<string> classNames = result.Select(className => className.Name).ToList();

            return classNames;
        }
    }
}
