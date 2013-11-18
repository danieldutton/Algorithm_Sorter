using Moq;
using NUnit.Framework;
using Sorter.Algorithms;
using Sorter.Algorithms.Routines;
using Sorter.Utilities.Async;
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
            var fakeCanSource = new Mock<ICancellationTokenSource>(); 
            var fakeStopwatch = new Mock<IStopwatch>();
            var fakeSortRoutine = new Mock<SortRoutine>(fakeStopwatch.Object);
            var sut = new SorterContext(fakeSortRoutine.Object);
            
            await sut.Sort(null, fakeCanSource.Object.Token);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async void ThrowAnArgumentOutOfRangeExceptionIfThereIsInsufficientDataToSort()
        {
            var fakeCanSource = new Mock<ICancellationTokenSource>();
            var fakeStopwatch = new Mock<IStopwatch>();
            var fakeSortRoutine = new Mock<SortRoutine>(fakeStopwatch.Object);
            var sut = new SorterContext(fakeSortRoutine.Object);

            await sut.Sort(new[] { 1 }, fakeCanSource.Object.Token);    
        }
    }
}
