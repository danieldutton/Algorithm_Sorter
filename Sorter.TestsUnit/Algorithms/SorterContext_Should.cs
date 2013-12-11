using Moq;
using NUnit.Framework;
using Sorter.Algorithms;
using Sorter.Algorithms.Routines;
using Sorter.Utilities._Stopwatch;
using Sorter.Utilities.Async;
using System;
using System.Threading;

namespace Sorter._UnitTests.Algorithms
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
        public async void Sort_ThrowAnArgumentNullExceptionIfDataToSortParameterIsNull()
        {
            var sut = new SorterContext(_fakeSortRoutine.Object);
            
            await sut.Sort(null, _fakeCancelSource.Object.Token);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async void Sort_ThrowAnArgumentOutOfRangeExceptionIfThereIsInsufficientDataToSort()
        {
            var sut = new SorterContext(_fakeSortRoutine.Object);

            await sut.Sort(new[] { 1 }, _fakeCancelSource.Object.Token);    
        }

        [Test]
        public  void Sort_CallSortAsyncMethodExactlyOnce()
        {
            var sut = new SorterContext(_fakeSortRoutine.Object);
            sut.Sort(new[] { 1, 2 }, _fakeCancelSource.Object.Token);
  
            _fakeSortRoutine.Verify(x => x.SortAsync(It.IsAny<int[]>(), It.IsAny<CancellationToken>()),
                Times.Once());
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
