using NUnit.Framework;
using Sorter.Algorithms.Routines;
using Sorter.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorter.UnitTests.Utilities
{
    [TestFixture]
    public class TypeNameExtractor_Should
    {
        private TypeNameExtractor _sut;

        [SetUp]
        public void Init()
        {
            _sut = new TypeNameExtractor();
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Load_ThrowAnArgumentException_IfAssemblyNameParam_IsAnEmptyString()
        {
            _sut.Load(string.Empty, typeof (SortRoutine));
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void Load_ThrowAnArgumentException_IfAssemblyNameParam_IsNull()
        {
            _sut.Load(null, typeof(SortRoutine));   
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Load_ThrowAnArgumentNullException_IfInheritsFromParam_IsNull()
        {
            _sut.Load("testString", null);    
        }

        [Test]
        public void Load_ReturnSortRoutineClassNames_InAlphabeticalOrderAscending()
        {
            List<string> actual = _sut.Load("Sorter.Algorithms.dll", typeof (SortRoutine));

            Assert.IsTrue(actual.SequenceEqual(Mother.ExpectedRoutineNameSequence));
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
        }
    }
}
