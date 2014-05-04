using System;
using System.Collections.Generic;

namespace Sorter.Utilities.Interfaces
{
    public interface ITypeNameExtractor
    {
        List<string> Load(string assemblyName, Type inheritsFrom);
    }
}
