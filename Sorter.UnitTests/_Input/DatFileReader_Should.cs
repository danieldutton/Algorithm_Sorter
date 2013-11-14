using Moq;
using NUnit.Framework;
using Sorter.Input;
using Sorter.Input.Exceptions;
using Sorter.Utilities.Readers;
using System;
using System.IO;
using System.Linq;
using System.Text;

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

        [Test]
        public void Read_ConvertTheStringMemoryStreamToIntegersCorrectCount()
        {
            var encoding = new UTF8Encoding();
            const string testString = "100 \n 200 \n 300 \n 400 \n 500";
            byte[] testArray = encoding.GetBytes((testString));
            var ms = new MemoryStream(testArray);
            var sr = new StreamReader(ms);
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            fakeStreamBuilder.SetupGet(x => x.StreamReader).Returns(() => sr);
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            string[] fPaths = new[] { "file 1" };
            int[] result = sut.Read(fPaths);

            Assert.AreEqual(5, result.Length);    
        }

        [Test]
        public void Read_MapTheStringReturnValuesToTheCorrectIntegers()
        {
            var encoding = new UTF8Encoding();
            const string testString = "100 \n 200 \n 300 \n 400 \n 500";
            byte[] testArray = encoding.GetBytes((testString));
            var ms = new MemoryStream(testArray);
            var sr = new StreamReader(ms);
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            fakeStreamBuilder.SetupGet(x => x.StreamReader).Returns(() => sr);
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            string[] fPaths = new[] { "file 1" };
            int[] expected = new[] { 100, 200, 300, 400, 500,};
            int[] actual = sut.Read(fPaths);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [Test]
        [ExpectedException(typeof(FileReadException))]
        public void ThrowAFormatExceptionIfAtLeastOneDataItemHasNoNewLineBreaker()
        {
            var encoding = new UTF8Encoding();
            const string testString = "100 \n 200 \n 300 \n 400 500";
            byte[] testArray = encoding.GetBytes((testString));
            var ms = new MemoryStream(testArray);
            var sr = new StreamReader(ms);
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            fakeStreamBuilder.SetupGet(x => x.StreamReader).Returns(() => sr);
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            string[] fPaths = new[] { "file 1" };
            int[] expected = new[] { 100, 200, 300, 400, 500, };
            int[] actual = sut.Read(fPaths);

            Assert.IsTrue(actual.SequenceEqual(expected));
        } 

        //ToDo Place some repetitive code in Mother.cs
    }
}
