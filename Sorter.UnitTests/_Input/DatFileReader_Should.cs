using Moq;
using NUnit.Framework;
using Sorter.Input;
using Sorter.Utilities.Readers;
using System;

namespace Sorter.UnitTests._Input
{
    [TestFixture]
    public class DatFileReader_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Read_ThrowAnArgumentNullExceptionIfFilePathsParamIsNull()
        {
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            sut.Read(null);
        }

        [Test]
        public void Read_CallBuildStreamReaderOncePerFilePath()
        {
            //var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            //fakeStreamBuilder.SetupProperty(x => x.StreamReader).SetReturnsDefault(()=> new StreamReader(It.IsAny<string>()));
            //var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            //sut.Read(new[] {"test1", "test2", "test3", "test4"});

            //fakeStreamBuilder.Verify(x => x.BuildStreamReader(It.IsAny<string>()));
        }
  
    }
}
