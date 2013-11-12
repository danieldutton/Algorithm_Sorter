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

            var datFileReader = new DatFileReader<int>(fakeStreamReader.Object);

            datFileReader.Read(null);
        }
  
    }
}
