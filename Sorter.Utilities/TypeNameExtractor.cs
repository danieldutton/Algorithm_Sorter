using Sorter.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Sorter.Utilities
{
    public class TypeNameExtractor : ITypeNameExtractor
    {
        public List<string> Load(string assemblyName, Type inheritsFrom)
        {
            if(string.IsNullOrWhiteSpace(assemblyName)) throw new ArgumentException();

            if(inheritsFrom == null) throw new ArgumentNullException();

            Assembly assembly = Assembly.LoadFrom(assemblyName);
            
            IEnumerable<Type> foundTypes = assembly
                .GetTypes()
                .Where(x => x.IsSubclassOf(inheritsFrom));

            List<string> classNames = foundTypes.
                Select(className => className.Name)
                .ToList();

            return classNames;
        }
    }
}
