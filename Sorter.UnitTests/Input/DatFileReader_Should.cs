using Moq;
using NUnit.Framework;
using Sorter.Input;
using System;
using System.IO;

namespace Sorter.UnitTests.Input
{
    [TestFixture]
    public class DatFileReader_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowAnArgumentNullExceptionIfFilePathsParamIsNull()
        {
            var fakeStreamReader = new Mock<TextReader>();
            fakeStreamReader.Setup(r => r.ReadLine()).Returns("1 2 3 4 5 6 7 8");

            var datFileReader = new DatFileReader<int>(fakeStreamReader.Object);

            datFileReader.Read(null);
        }
  
    }
}
