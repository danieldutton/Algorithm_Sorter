using Moq;
using NUnit.Framework;
using Sorter.Algorithms.EventArg;
using Sorter.Algorithms.Routines;
using Sorter.Timer;
using System.Linq;

namespace Sorter.UnitTests.Algorithms
{
    [TestFixture]
    public class MergeSort_Should
    {
        private int[] _tenUnsortedInts;

        private int[] _oneHundredUnsortedInts;

        [SetUp]
        public void Init()
        {
            _tenUnsortedInts = Mother.GetTenUnsortedIntegers();
            _oneHundredUnsortedInts = Mother.GetOneHundredUnSortedIntegers();
        }

        [Test]
        public void SortAsync_FireAStartedEvent()
        {
            bool wasFired = false;
            var fakeTimer = new Mock<ITimer>();
            var sut = new MergeSort(fakeTimer.Object);
            sut.Started += (o, e) => wasFired = true;

            sut.SortAsync(_tenUnsortedInts);

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SortAsync_CallTimerStartMethodExactlyOnce()
        {
            var fakeTimer = new Mock<ITimer>();
            var sut = new MergeSort(fakeTimer.Object);

            sut.SortAsync(_tenUnsortedInts);

            fakeTimer.Verify(x => x.Start(), Times.Once());
        }

        [Test]
        public void SortAsync_CallTimerStopMethodExactlyOnce()
        {
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new MergeSort(fakeTimer.Object);

            sut.SortAsync(_tenUnsortedInts);

            fakeTimer.Verify(x => x.Stop(), Times.Once());
        }

        [Test]
        public async void SortAsync_FireACompletedEvent()
        {
            bool wasFired = false;
            var fakeTimer = new Mock<ITimer>();
            var sut = new MergeSort(fakeTimer.Object);
            sut.Completed += (o, e) => wasFired = true;

            await sut.SortAsync(_tenUnsortedInts);

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SortAsync_CallTimer_StartTime_GetterExactlyOnce()
        {
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.Setup(x => x.Start());
            var sut = new MergeSort(fakeTimer.Object);

            sut.SortAsync(_tenUnsortedInts);

            fakeTimer.VerifyGet(x => x.StartTime, Times.Exactly(1));
        }

        [Test]
        public void SortAsync_CallTimer_StopTime_GetterExactlyOnce()
        {
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new MergeSort(fakeTimer.Object);

            sut.SortAsync(_tenUnsortedInts);

            fakeTimer.VerifyGet(x => x.StopTime, Times.Exactly(1));
        }

        [Test]
        public void SortAsync_CallTimer_Elapsed_GetterExactlyOnce()
        {
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new MergeSort(fakeTimer.Object);

            sut.SortAsync(_tenUnsortedInts);

            fakeTimer.VerifyGet(x => x.ElapsedTime, Times.Exactly(1));
        }

        [Test]
        public async void SortAsync_FireACompletedEventWithTheCorrectEventArgsData()
        {
            var fakeTimer = new Mock<ITimer>();

            fakeTimer.SetupGet(x => x.StartTime).Returns(Mother.GetTestStartTime());
            fakeTimer.SetupGet(x => x.StopTime).Returns(Mother.GetTestStopTime());
            fakeTimer.SetupGet(x => x.ElapsedTime).Returns(Mother.GetTestElapsedTime);

            var sut = new MergeSort(fakeTimer.Object);
            SortingCompleteEventArgs sortCompleteEventArgs = null;
            sut.Completed += (o, e) => sortCompleteEventArgs = e;

            await sut.SortAsync(_tenUnsortedInts);

            Assert.AreEqual(Mother.GetTestStartTime(), sortCompleteEventArgs.StartTimeInMs);
            Assert.AreEqual(Mother.GetTestStopTime(), sortCompleteEventArgs.StopTimeInMs);
            Assert.AreEqual(Mother.GetTestElapsedTime(), sortCompleteEventArgs.ElapsedTimeInMs);
        }

        [Test]
        public async void SortAsync_CorrectlySortDataTenItemsGivenInTheUnsortedArrayArray()
        {
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());

            var sut = new MergeSort(fakeTimer.Object);

            int[] result = await sut.SortAsync(_tenUnsortedInts);

            Assert.IsTrue(Mother.GetTenSortedIntegers().SequenceEqual(result));
        }

        [Test]
        public async void SortAsync_CorrectlySortDataOneHundredItemsGivenInTheUnsortedArrayArray()
        {
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());

            var sut = new MergeSort(fakeTimer.Object);

            int[] result = await sut.SortAsync(_oneHundredUnsortedInts);

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
