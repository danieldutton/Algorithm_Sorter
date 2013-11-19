using NUnit.Framework;
using Sorter.Algorithms.Routines;
using Sorter.Utilities.Algorithms;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorter.TestsUnit.Utilities
{
    [TestFixture]
    public class ClassNameLoader_Should
    {
        private RoutineNameLoader _sut;

        [SetUp]
        public void Init()
        {
            _sut = new RoutineNameLoader();
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Load_ThrowAnArgumentExceptionIfAssemblyNameParamIsAnEmptyString()
        {
            _sut.Load(string.Empty, typeof (SortRoutine));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Load_ThrowAnArgumentExceptionIfAssemblyNameParamIsNull()
        {
            _sut.Load(null, typeof(SortRoutine));   
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Load_ThrowAnArgumentNullExceptionIfInheritsFromParamIsNull()
        {
            _sut.Load("test", null);    
        }

        [Test]
        public void Load_ReturnAListOfCorrectAlgorithmClassNames()
        {
            var expected = new List<string>{"BubbleSort", "HeapSort", "InsertionSort", "QuickSort", "SelectionSort", "ShellSort"};
            List<string> actual = _sut.Load("Sorter.Algorithms.dll", typeof (SortRoutine));

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
