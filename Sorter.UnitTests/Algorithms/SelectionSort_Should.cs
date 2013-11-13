using Moq;
using NUnit.Framework;
using Sorter.Algorithms.Routines;
using Sorter.Timer;

namespace Sorter.UnitTests.Algorithms
{
    [TestFixture]
    public class SelectionSort_Should
    {
        [Test]
        public void SortAsync_FireAStartedEvent()
        {
            bool wasFired = false;
            var fakeTimer = new Mock<ITimer>();
           
            var sut = new SelectionSort(fakeTimer.Object);
            sut.Started += (o, e) => wasFired = true;

            int[] unsorted = new[] {7, 2, 9, 1, 4, 2, 8, 3, 5, 10, 6};

            sut.SortAsync(unsorted);

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SortAsync_CallTimerStartMethod()
        {
            var fakeTimer = new Mock<ITimer>();
            var sut = new SelectionSort(fakeTimer.Object);
            int[] unsorted = new[] { 7, 2, 9, 1, 4, 2, 8, 3, 5, 10, 6 };

            sut.SortAsync(unsorted);

            fakeTimer.Verify(x => x.Start(), Times.Once());
        }

        [Test]
        public void SortAsync_CallTimerStopMethod()
        {
            var fakeTimer = new Mock<ITimer>();
            var sut = new SelectionSort(fakeTimer.Object);
            int[] unsorted = new[] { 7, 2, 9, 1, 4, 2, 8, 3, 5, 10, 6 };

            sut.SortAsync(unsorted);

            fakeTimer.Verify(x => x.Stop(), Times.Once());   
        }

        [Test]
        public void SortAsync_FireACompletedEvent()
        {
            bool wasFired = false;
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.Setup(x => x.Start());
            fakeTimer.Setup(x => x.Stop());
            fakeTimer.SetupGet(x => x.StartTime).Returns(It.IsAny<double>());
            fakeTimer.SetupGet(x => x.StopTime).Returns(It.IsAny<double>());
            fakeTimer.SetupGet(x => x.ElapsedTime).Returns(It.IsAny<double>());

            var sut = new SelectionSort(fakeTimer.Object);
            sut.Completed += (o, e) => wasFired = true;

            int[] unsorted = new[] { 7, 2, 9, 1, 4, 2, 8, 3, 5, 10, 6 };

            sut.SortAsync(unsorted);

            Assert.IsTrue(wasFired);    
        }

        [Test]
        public void SortAsync_TimerStartTimeGetterWasCalled()
        {
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.Setup(x => x.Start());
            fakeTimer.Setup(x => x.Stop());
            fakeTimer.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new SelectionSort(fakeTimer.Object);

            int[] unsorted = new[] { 7, 2, 9, 1, 4, 2, 8, 3, 5, 10, 6 };

            sut.SortAsync(unsorted);

            fakeTimer.VerifyGet(x => x.StartTime, Times.Exactly(1));
        }

        [Test]
        public void SortAsync_TimerStopTimeGetterWasCalled()
        {
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.Setup(x => x.Start());
            fakeTimer.Setup(x => x.Stop());
            fakeTimer.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new SelectionSort(fakeTimer.Object);

            int[] unsorted = new[] { 7, 2, 9, 1, 4, 2, 8, 3, 5, 10, 6 };

            sut.SortAsync(unsorted);

            fakeTimer.VerifyGet(x => x.StopTime, Times.Exactly(1));
        }

        [Test]
        public void SortAsync_TimerElapsedTimeGetterWasCalled()
        {
            var fakeTimer = new Mock<ITimer>();
            fakeTimer.Setup(x => x.Start());
            fakeTimer.Setup(x => x.Stop());
            fakeTimer.SetupAllProperties().SetReturnsDefault(It.IsAny<double>());
            var sut = new SelectionSort(fakeTimer.Object);

            int[] unsorted = new[] { 7, 2, 9, 1, 4, 2, 8, 3, 5, 10, 6 };

            sut.SortAsync(unsorted);

            fakeTimer.VerifyGet(x => x.ElapsedTime, Times.Exactly(1));
        }

        [Test]
        public void SortAsync_FireACompletedEventWithTheCorrectEventArgsData()
        {
            
        }

        [Test]
        public void SortAsync_CorrectlySortDataInAnArray()
        {
            
        }
    }
}
