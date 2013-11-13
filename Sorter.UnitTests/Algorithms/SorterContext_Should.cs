using Moq;
using NUnit.Framework;
using Sorter.Algorithms;
using Sorter.Algorithms.Routines;
using Sorter.Timer;
using System;

namespace Sorter.UnitTests.Algorithms
{
    public class SorterContext_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowAnArgumentNullExceptionIfDataToSortParameterIsNull()
        {
            var fakeTimer = new Mock<ITimer>();
            var fakeSortRoutine = new Mock<SortRoutine>(fakeTimer.Object);
            var sut = new SorterContext(fakeSortRoutine.Object);
            
            sut.Sort(null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ThrowAnArgumentOutOfRangeExceptionIfThereIsInsufficientDataToSort()
        {
            var fakeTimer = new Mock<ITimer>();
            var fakeSortRoutine = new Mock<SortRoutine>(fakeTimer.Object);
            var sut = new SorterContext(fakeSortRoutine.Object);

            sut.Sort(new []{1});    
        }
    }
}
