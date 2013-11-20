using Moq;
using NUnit.Framework;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Routines;
using Sorter.Utilities._Stopwatch;
using Sorter.Utilities.Async;
using System.Linq;

namespace Sorter.TestsUnit._Algorithms.Routines
{
    [TestFixture]
    public class BubbleSort_Should
    {
        private int[] _tenUnsortedInts;

        private int[] _oneHundredUnsortedInts;

        private Mock<ICancellationTokenSource> _fakeCancelSource;

        private Mock<IStopwatch> _fakeStopwatch;

        [SetUp]
        public void Init()
        {
            _tenUnsortedInts = Mother.GetTenUnsortedIntegers();
            _oneHundredUnsortedInts = Mother.GetOneHundredUnSortedIntegers();
            _fakeCancelSource = new Mock<ICancellationTokenSource>();
            _fakeStopwatch = new Mock<IStopwatch>();
        }

        [Test]
        public void SortAsync_FireAStartedEvent()
        {
            bool wasFired = false;
            var sut = new BubbleSort(_fakeStopwatch.Object);
            sut.Started += (o, e) => wasFired = true;

            sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SortAsync_CallStopwatchStartMethodExactlyOnce()
        {
            var sut = new BubbleSort(_fakeStopwatch.Object);
            sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            _fakeStopwatch.Verify(x => x.Start(), Times.Once());
        }

        [Test]
        public async void SortAsync_CallStopwatchStopMethodExactlyOnce()
        {
            _fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new BubbleSort(_fakeStopwatch.Object);

            await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            _fakeStopwatch.Verify(x => x.Stop(), Times.Once());
        }

        [Test]
        public async void SortAsync_FireACompletedEvent()
        {
            bool wasFired = false;
            var sut = new BubbleSort(_fakeStopwatch.Object);
            sut.Completed += (o, e) => wasFired = true;

            await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.IsTrue(wasFired);
        }

        [Test]
        public async void SortAsync_CallStopwatch_ElapsedMilliseconds_GetterExactlyOnce()
        {
            _fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new BubbleSort(_fakeStopwatch.Object);

            await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            _fakeStopwatch.VerifyGet(x => x.ElapsedMilliseconds, Times.Exactly(1));
        }

        [Test]
        public async void SortAsync_FireACompletedEventWithTheCorrectElapsedTimeValue()
        {
            _fakeStopwatch.SetupGet(x => x.ElapsedMilliseconds).Returns(Mother.GetTestElapsedTime);

            var sut = new BubbleSort(_fakeStopwatch.Object);
            SortCompleteEventArgs sortCompleteEventArgs = null;
            sut.Completed += (o, e) => sortCompleteEventArgs = e;

            await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.AreEqual(Mother.GetTestElapsedTime(), sortCompleteEventArgs.ElapsedTimeMilliSec);
            Assert.AreEqual(10, sortCompleteEventArgs.ItemSortCount);
        }

        [Test]
        public async void SortAsync_CorrectlySortTenItemsGivenInTheUnsortedArray()
        {
            _fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new BubbleSort(_fakeStopwatch.Object);

            int[] result = await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.IsTrue(Mother.GetTenSortedIntegers().SequenceEqual(result));
        }

        [Test]
        public async void SortAsync_CorrectlySortOneHundredItemsGivenInTheUnsortedArray()
        {
            _fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new BubbleSort(_fakeStopwatch.Object);

            int[] result = await sut.SortAsync(_oneHundredUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.IsTrue(Mother.GetOneHundredSortedIntegers().SequenceEqual(result));
        }

        //Todo Check Cancel worked

        [TearDown]
        public void TearDown()
        {
            _tenUnsortedInts = null;
            _oneHundredUnsortedInts = null;
            _fakeCancelSource = null;
            _fakeStopwatch = null;
        }
    }
}
