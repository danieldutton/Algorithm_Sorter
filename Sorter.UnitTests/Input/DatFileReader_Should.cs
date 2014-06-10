using Moq;
using NUnit.Framework;
using Sorter.Input;
using Sorter.Utilities.Interfaces;
using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Sorter.UnitTests.Input
{
    [TestFixture]
    public class DatFileReader_Should
    {
        private UTF8Encoding _utf8Encoding;

        [SetUp]
        public void Init()
        {
            _utf8Encoding = new UTF8Encoding();
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Read_ThrowAnArgumentNullExceptionIfFilePathsParamIsNull()
        {
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            sut.Read(null);
        }

        [Test]
        public void Read_CallBuildStreamReader_OncePerFilePath()
        {
            const string testString = "100";
            byte[] testArray = _utf8Encoding.GetBytes((testString));
            var memoryStream = new MemoryStream(testArray);       
            var streamReader = new StreamReader(memoryStream);
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            fakeStreamBuilder.SetupGet(x => x.StreamReader).Returns(() => streamReader);
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);
            
            string[] filePaths = {"file 1", "file 2", "file 3", "file 4", "file5", "file6"};
            sut.Read(filePaths);

            fakeStreamBuilder.Verify(x => x.BuildStreamReader(It.IsAny<string>()),Times.Exactly(6));
        }

        [Test]
        public void Read_ConvertTheStringMemoryStream_ToIntegersCorrectCount()
        {
            byte[] testArray = _utf8Encoding.GetBytes(Mother.FaultFreeTestString);
            var memoryStream = new MemoryStream(testArray);
            var streamReader = new StreamReader(memoryStream);
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            fakeStreamBuilder.SetupGet(x => x.StreamReader).Returns(() => streamReader);
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            string[] filePaths = { "file 1" };
            int[] result = sut.Read(filePaths);

            Assert.AreEqual(5, result.Length);    
        }

        [Test]
        public void Read_MapTheStringReturnValues_ToTheCorrectIntegers()
        {
            byte[] testArray = _utf8Encoding.GetBytes(Mother.FaultFreeTestString);
            var memoryStream = new MemoryStream(testArray);
            var streamReader = new StreamReader(memoryStream);
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            fakeStreamBuilder.SetupGet(x => x.StreamReader).Returns(() => streamReader);
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            string[] filePaths = { "file 1" };
            int[] expected = { 100, 200, 300, 400, 500,};
            int[] actual = sut.Read(filePaths);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [Test]
        [ExpectedException(typeof(FormatException))]
        public void ThrowAFormatException_IfAtLeastOneDataItemHasNoNewLineBreak()
        {
            byte[] testArray = _utf8Encoding.GetBytes(Mother.FaultyTestString);
            var memoryStream = new MemoryStream(testArray);
            var streamReader = new StreamReader(memoryStream);
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            fakeStreamBuilder.SetupGet(x => x.StreamReader).Returns(() => streamReader);
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            string[] filePaths = { "file 1" };
            int[] expected = { 100, 200, 300, 400, 500, };
            int[] actual = sut.Read(filePaths);

            Assert.IsTrue(actual.SequenceEqual(expected));
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void ThrowAFormatException_IfASystemDotExceptionOccursDuringExecution()
        {
            var fakeStreamBuilder = new Mock<IStreamReaderBuilder>();
            fakeStreamBuilder.SetupGet(x => x.StreamReader).Throws<Exception>();
            var sut = new DatFileReader<int>(fakeStreamBuilder.Object);

            string[] filePaths = { "file 1" };
            int[] expected = { 100, 200, 300, 400, 500, };
            int[] actual = sut.Read(filePaths);

            Assert.IsTrue(actual.SequenceEqual(expected));
        } 
    }
}
