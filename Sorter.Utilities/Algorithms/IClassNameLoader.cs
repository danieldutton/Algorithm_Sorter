﻿using System;
using System.Collections.Generic;

namespace Sorter.Utilities.Algorithms
{
    public interface IClassNameLoader
    {
        List<string> Load(string assemblyName, Type inheritsFrom);
    }
}
