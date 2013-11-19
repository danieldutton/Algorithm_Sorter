using Moq;
using NUnit.Framework;
using Sorter.Algorithms;
using Sorter.Algorithms.Routines;
using Sorter.Utilities._Stopwatch;
using Sorter.Utilities.Async;
using System;

namespace Sorter.TestsUnit._Algorithms
{
    public class SorterContext_Should
    {
        private Mock<ICancellationTokenSource> _fakeCancelSource;

        private Mock<IStopwatch> _fakeStopwatch;

        private Mock<SortRoutine> _fakeSortRoutine;
        
        [SetUp]
        public void Init()
        {
            _fakeCancelSource = new Mock<ICancellationTokenSource>(); 
            _fakeStopwatch = new Mock<IStopwatch>();
            _fakeSortRoutine = new Mock<SortRoutine>(_fakeStopwatch.Object);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public async void ThrowAnArgumentNullExceptionIfDataToSortParameterIsNull()
        {
            var sut = new SorterContext(_fakeSortRoutine.Object);
            
            await sut.Sort(null, _fakeCancelSource.Object.Token);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async void ThrowAnArgumentOutOfRangeExceptionIfThereIsInsufficientDataToSort()
        {
            var sut = new SorterContext(_fakeSortRoutine.Object);

            await sut.Sort(new[] { 1 }, _fakeCancelSource.Object.Token);    
        }

        [TearDown]
        public void TearDown()
        {
            _fakeCancelSource = null;
            _fakeStopwatch = null;
            _fakeSortRoutine = null;
        }
    }
}
