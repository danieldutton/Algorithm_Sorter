using Moq;
using NUnit.Framework;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Routines;
using Sorter.Utilities.Interfaces;
using System.Linq;

namespace Sorter.UnitTests.Algorithms.Routines
{
    [TestFixture]
    public class OddEvenSort_Should
    {
        private int[] _tenUnsortedInts;

        private int[] _oneHundredUnsortedInts;

        private Mock<ICancelTokenSource> _fakeCancelSource;

        private Mock<ITimer> _fakeStopwatch;

        [SetUp]
        public void Init()
        {
            _tenUnsortedInts = Mother.GetTenUnsortedIntegers();
            _oneHundredUnsortedInts = Mother.GetOneHundredRandomlyPlacedIntegers();
            _fakeCancelSource = new Mock<ICancelTokenSource>();
            _fakeStopwatch = new Mock<ITimer>();
        }

        [Test]
        public void SortAsync_FireAStartedEvent()
        {
            bool wasFired = false;
            var sut = new OddEvenSort(_fakeStopwatch.Object);
            sut.Started += (o, e) => wasFired = true;

            sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SortAsync_CallStopwatchStartMethodExactlyOnce()
        {
            var sut = new OddEvenSort(_fakeStopwatch.Object);
            sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            _fakeStopwatch.Verify(x => x.StartTimer(), Times.Once());
        }

        [Test]
        public async void SortAsync_CallStopwatchStopMethodExactlyOnce()
        {
            _fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new OddEvenSort(_fakeStopwatch.Object);

            await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            _fakeStopwatch.Verify(x => x.StopTimer(), Times.Once());
        }

        [Test]
        public async void SortAsync_FireACompletedEvent()
        {
            bool wasFired = false;
            var sut = new OddEvenSort(_fakeStopwatch.Object);
            sut.Complete += (o, e) => wasFired = true;

            await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.IsTrue(wasFired);
        }

        [Test]
        public async void SortAsync_CallStopwatch_ElapsedMilliseconds_GetterExactlyOnce()
        {
            _fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new OddEvenSort(_fakeStopwatch.Object);

            await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            _fakeStopwatch.VerifyGet(x => x.TimeElapsedMs, Times.Exactly(1));
        }

        [Test]
        public async void SortAsync_FireACompletedEventWithTheCorrectElapsedTimeValue()
        {
            _fakeStopwatch.SetupGet(x => x.TimeElapsedMs).Returns(Mother.ElapsedTimeStub);

            var sut = new OddEvenSort(_fakeStopwatch.Object);
            SortCompleteEventArgs sortCompleteEventArgs = null;
            sut.Complete += (o, e) => sortCompleteEventArgs = e;

            await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.AreEqual(Mother.ElapsedTimeStub, sortCompleteEventArgs.ElapsedTimeMilliSec);
            Assert.AreEqual(10, sortCompleteEventArgs.ItemSortCount);
        }

        [Test]
        public async void SortAsync_CorrectlySortTenItemsGivenInTheUnsortedArray()
        {
            _fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new OddEvenSort(_fakeStopwatch.Object);

            int[] result = await sut.SortAsync(_tenUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.IsTrue(Mother.GetTenSortedIntegers().SequenceEqual(result));
        }

        [Test]
        public async void SortAsync_CorrectlySortOneHundredItemsGivenInTheUnsortedArray()
        {
            _fakeStopwatch.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new OddEvenSort(_fakeStopwatch.Object);

            int[] result = await sut.SortAsync(_oneHundredUnsortedInts, _fakeCancelSource.Object.Token);

            Assert.IsTrue(Mother.GetOneHundredSortedIntegers().SequenceEqual(result));
        }

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
