using Moq;
using NUnit.Framework;
using Sorter.Algorithms;
using Sorter.Algorithms.Routines;
using Sorter.Utilities.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Sorter.UnitTests.Algorithms
{
    public class SorterContext_Should
    {
        private Mock<ICancelTokenSource> _fakeCancelSource;

        private Mock<ITimer> _fakeStopwatch;

        private Mock<SortRoutine> _fakeSortRoutine;
        
        [SetUp]
        public void Init()
        {
            _fakeCancelSource = new Mock<ICancelTokenSource>(); 
            _fakeStopwatch = new Mock<ITimer>();
            _fakeSortRoutine = new Mock<SortRoutine>(_fakeStopwatch.Object);
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public async void Sort_ThrowAnArgumentNullExceptionIfDataToSortParameterIsNull()
        {
            var sut = new SorterContext(_fakeSortRoutine.Object);
            
            await sut.SortAsync(null, _fakeCancelSource.Object.Token);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public async void Sort_ThrowAnArgumentOutOfRangeExceptionIfThereIsInsufficientDataToSort()
        {
            var sut = new SorterContext(_fakeSortRoutine.Object);

            await sut.SortAsync(new[] { 1 }, _fakeCancelSource.Object.Token);    
        }

        [Test]
        public  void Sort_CallSortAsyncMethodExactlyOnce()
        {
            var sut = new SorterContext(_fakeSortRoutine.Object);
            sut.SortAsync(new[] { 1, 2 }, _fakeCancelSource.Object.Token);
  
            _fakeSortRoutine.Verify(x => x.SortAsync(It.IsAny<int[]>(), It.IsAny<CancellationToken>()),
                Times.Once());
        }

        [Test]
        public void Sort_ReturnTheCorrectDataType()
        {
            var sut = new SorterContext(_fakeSortRoutine.Object);
            Task<int[]> result= sut.SortAsync(new[] { 1, 2 }, _fakeCancelSource.Object.Token);

            Assert.IsInstanceOf<Task<int[]>>(result);
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
