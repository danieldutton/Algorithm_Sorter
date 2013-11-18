using Moq;
using NUnit.Framework;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Routines;
using Sorter.Utilities.Async;
using Sorter.Utilities._Stopwatch;
using System.Linq;

namespace Sorter.UnitTests._Algorithms.Routines
{
    [TestFixture]
    public class QuickSort_Should
    {
        private int[] _tenUnsortedInts;

        private int[] _oneHundredUnsortedInts;

        private Mock<ICancellationTokenSource> _fakeCanSource;

        [SetUp]
        public void Init()
        {
            _tenUnsortedInts = Mother.GetTenUnsortedIntegers();
            _oneHundredUnsortedInts = Mother.GetOneHundredUnSortedIntegers();
            _fakeCanSource = new Mock<ICancellationTokenSource>();
        }

        [Test]
        public void SortAsync_FireAStartedEvent()
        {
            bool wasFired = false;
            var fakeStopwatch = new Mock<IStopwatch>();
            var sut = new QuickSort(fakeStopwatch.Object);
            sut.Started += (o, e) => wasFired = true;

            sut.SortAsync(_tenUnsortedInts, _fakeCanSource.Object.Token);

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SortAsync_CallStopwatchStartMethodExactlyOnce()
        {
            var fakeStopwatch = new Mock<IStopwatch>();
            var sut = new QuickSort(fakeStopwatch.Object);

            sut.SortAsync(_tenUnsortedInts, _fakeCanSource.Object.Token);

            fakeStopwatch.Verify(x => x.Start(), Times.Once());
        }

        [Test]
        public async void SortAsync_CallStopwatchStopMethodExactlyOnce()
        {
            var fakeStopwatch = new Mock<IStopwatch>();
            fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new QuickSort(fakeStopwatch.Object);

            await sut.SortAsync(_tenUnsortedInts, _fakeCanSource.Object.Token);

            fakeStopwatch.Verify(x => x.Stop(), Times.Once());
        }

        [Test]
        public async void SortAsync_FireACompletedEvent()
        {
            bool wasFired = false;
            var fakeStopwatch = new Mock<IStopwatch>();
            var sut = new QuickSort(fakeStopwatch.Object);
            sut.Completed += (o, e) => wasFired = true;

            await sut.SortAsync(_tenUnsortedInts, _fakeCanSource.Object.Token);

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SortAsync_CallStopwatch_ElapsedMilliseconds_GetterExactlyOnce()
        {
            var fakeStopwatch = new Mock<IStopwatch>();
            fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new QuickSort(fakeStopwatch.Object);

            sut.SortAsync(_tenUnsortedInts, _fakeCanSource.Object.Token);

            fakeStopwatch.VerifyGet(x => x.ElapsedMilliseconds, Times.Exactly(1));
        }

        [Test]
        public async void SortAsync_FireACompletedEventWithTheCorrectElapsedTimeValue()
        {
            var fakeStopwatch = new Mock<IStopwatch>();
            fakeStopwatch.SetupGet(x => x.ElapsedMilliseconds).Returns(Mother.GetTestElapsedTime);

            var sut = new QuickSort(fakeStopwatch.Object);
            SortCompleteEventArgs sortCompleteEventArgs = null;
            sut.Completed += (o, e) => sortCompleteEventArgs = e;

            await sut.SortAsync(_tenUnsortedInts, _fakeCanSource.Object.Token);

            Assert.AreEqual(Mother.GetTestElapsedTime(), sortCompleteEventArgs.ElapsedTimeMilliSec);
            Assert.AreEqual(10, sortCompleteEventArgs.ItemSortCount);
        }

        [Test]
        public async void SortAsync_CorrectlySortDataTenItemsGivenInTheUnsortedArrayArray()
        {
            var fakeStopwatch = new Mock<IStopwatch>();
            fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());

            var sut = new QuickSort(fakeStopwatch.Object);

            int[] result = await sut.SortAsync(_tenUnsortedInts, _fakeCanSource.Object.Token);

            Assert.IsTrue(Mother.GetTenSortedIntegers().SequenceEqual(result));
        }

        [Test]
        public async void SortAsync_CorrectlySortDataOneHundredItemsGivenInTheUnsortedArrayArray()
        {
            var fakeStopwatch = new Mock<IStopwatch>();
            fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());

            var sut = new QuickSort(fakeStopwatch.Object);

            int[] result = await sut.SortAsync(_oneHundredUnsortedInts, _fakeCanSource.Object.Token);

            Assert.IsTrue(Mother.GetOneHundredSortedIntegers().SequenceEqual(result));
        }

        [TearDown]
        public void TearDown()
        {
            _tenUnsortedInts = null;
            _oneHundredUnsortedInts = null;
        }
    }
}
