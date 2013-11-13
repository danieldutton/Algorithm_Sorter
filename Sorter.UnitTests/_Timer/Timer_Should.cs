using System;
using Moq;
using NUnit.Framework;
using Sorter.Utilities.DateTimes;

namespace Sorter.UnitTests._Timer
{
    [TestFixture]
    public class Timer_Should
    {
        [Test]
        public void Start_CallCurrentTimeInMilliseconds()
        {
            var fakeTimeProvider = new Mock<ICurrentTimeProvider>();
            var sut = new Timer.Timer(fakeTimeProvider.Object);

            sut.Start();

            fakeTimeProvider.Verify(x => x.CurrentTimeInMilliseconds(), Times.Once());
        }

        [Test]
        public void Start_SetStartTimeOn_StartTime_Setter()
        {
            var fakeTimeProvider = new Mock<ICurrentTimeProvider>();
            fakeTimeProvider.Setup(x => x.CurrentTimeInMilliseconds()).Returns(200);
            var sut = new Timer.Timer(fakeTimeProvider.Object);

            sut.Start();

            Assert.AreEqual(200, sut.StartTime);   
        }

        [Test]
        public void Stop_CallCurrentTimeInMilliseconds()
        {
            var fakeTimeProvider = new Mock<ICurrentTimeProvider>();
            var sut = new Timer.Timer(fakeTimeProvider.Object);

            sut.Stop();

            fakeTimeProvider.Verify(x => x.CurrentTimeInMilliseconds(), Times.Once());    
        }

        [Test]
        public void Start_SetStopTimeOn_StopTime_Setter()
        {
            var fakeTimeProvider = new Mock<ICurrentTimeProvider>();
            fakeTimeProvider.Setup(x => x.CurrentTimeInMilliseconds()).Returns(200);
            var sut = new Timer.Timer(fakeTimeProvider.Object);

            sut.Stop();

            Assert.AreEqual(200, sut.StopTime);
        }

        [Test]
        public void ElapsedTime_ProvideTheCorrectTimeDifference()
        {
            var fakeTimeProvider = new Mock<ICurrentTimeProvider>();
            var sut = new Timer.Timer(fakeTimeProvider.Object)
                {
                    StartTime = 725, StopTime = 1000
                };

            Assert.AreEqual(275, sut.ElapsedTime);
        }
    }
}
