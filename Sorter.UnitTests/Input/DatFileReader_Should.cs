using System;
using System.IO;
using Moq;
using NUnit.Framework;
using Sorter.Input;

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

            var datFileReader = new DatFileFileReader<int>(fakeStreamReader.Object);

            datFileReader.Read(null);
        }
    }
}
