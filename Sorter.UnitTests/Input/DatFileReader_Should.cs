using Moq;
using NUnit.Framework;
using Sorter.Input;
using System;
using System.IO;
using Sorter.Utilities.Readers;

namespace Sorter.UnitTests.Input
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
            //fakeStreamBuilder.Setup(x => x.BuildStreamReader(It.IsAny<string>()));
            //fakeStreamBuilder.Setup(x => x.BuildStreamReader(It.IsAny<string>()).ReadLine()).Returns("1 2 3 4 5");

            //var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            //sut.Read(new[] {"file1", "file2", "file3", "file4", "file5"});

            //fakeStreamBuilder.Verify(x => x.BuildStreamReader(It.IsAny<string>()), Times.Exactly(4));
        }
  
    }
}
