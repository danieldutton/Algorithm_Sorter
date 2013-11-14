using System.Text;
using Moq;
using NUnit.Framework;
using Sorter.Input;
using Sorter.Utilities.Readers;
using System;
using System.IO;

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
            var encoding = new UTF8Encoding();
            const string testString = "100";
            byte[] testArray = encoding.GetBytes((testString));
            var ms = new MemoryStream(testArray);       
            var sr = new StreamReader(ms);
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            fakeStreamBuilder.SetupGet(x => x.StreamReader).Returns(() => sr);
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);
            
            string[] fPaths = new[] {"file 1", "file 2", "file 3", "file 4", "file5", "file6"};
            sut.Read(fPaths);

            fakeStreamBuilder.Verify(x => x.BuildStreamReader(It.IsAny<string>()),Times.Exactly(6));
        }
  
    }
}
