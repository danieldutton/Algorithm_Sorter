using NUnit.Framework;
using Sorter.Input;
using Sorter.Utilities.Interfaces;
using Sorter.Utilities.Wrappers;

namespace Sorter.IntegrationTests.Input
{
    [TestFixture]
    public class DatFileReader_Should
    {
        private IStreamReaderBuilder _streamReaderBuilder;

        private DatFileReader<int> _sut;
        
        [SetUp]
        public void Init()
        {
            _streamReaderBuilder = new StreamReaderWrapper();

            _sut = new DatFileReader<int>(_streamReaderBuilder);
        }

        [Test]
        public void Read_32000Integers_FromTestFile_Ran32000()
        {
            const string filePath = @"TestFiles\ran32000.dat";
            
            int[] result = _sut.Read(new[] { filePath });
            
            Assert.AreEqual(32000, result.Length);
            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }

        [Test]
        public void Read_64000Integers_FromTestFile_Ran64000()
        {
            const string filePath = @"TestFiles\ran64000.dat";

            int[] result = _sut.Read(new[] { filePath });

            Assert.AreEqual(64000, result.Length);
            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }

        [Test]
        public void Read_128000IntegersFromTestFile_Ran128000()
        {
            const string filePath = @"TestFiles\ran128000.dat";

            int[] result = _sut.Read(new[] { filePath });

            Assert.AreEqual(128000, result.Length);
            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }

        [Test]
        public void Read_256000Integers_FromTestFile_Ran256000()
        {
            const string filePath = @"TestFiles\ran256000.dat";

            int[] result = _sut.Read(new[] { filePath });

            Assert.AreEqual(256000, result.Length);
            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }

        [Test]
        public void Read_512000Integers_FromTestFile_Ran512000()
        {
            const string filePath = @"TestFiles\ran512000.dat";

            int[] result = _sut.Read(new[] { filePath });

            Assert.AreEqual(512000, result.Length);
            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }

        [TearDown]
        public void TearDown()
        {
            _streamReaderBuilder = null;
            _sut = null;
        }
    }
}
