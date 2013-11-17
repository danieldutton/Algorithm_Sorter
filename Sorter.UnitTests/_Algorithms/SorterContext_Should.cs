using Moq;
using NUnit.Framework;
using Sorter.Algorithms;
using Sorter.Algorithms.Routines;
using Sorter.Utilities._Stopwatch;
using System;

namespace Sorter.UnitTests._Algorithms
{
    public class SorterContext_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public async void ThrowAnArgumentNullExceptionIfDataToSortParameterIsNull()
        {
            var fakeTimer = new Mock<IStopwatch>();
            var fakeSortRoutine = new Mock<SortRoutine>(fakeTimer.Object);
            var sut = new SorterContext(fakeSortRoutine.Object);
            
            await sut.Sort(null);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async void ThrowAnArgumentOutOfRangeExceptionIfThereIsInsufficientDataToSort()
        {
            var fakeTimer = new Mock<IStopwatch>();
            var fakeSortRoutine = new Mock<SortRoutine>(fakeTimer.Object);
            var sut = new SorterContext(fakeSortRoutine.Object);

            await sut.Sort(new []{1});    
        }
    }
}
