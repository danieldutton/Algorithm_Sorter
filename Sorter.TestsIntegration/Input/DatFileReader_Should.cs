using NUnit.Framework;
using Sorter.Input;
using Sorter.Utilities.Readers;

namespace Sorter.TestsIntegration.Input
{
    [TestFixture]
    public class DatFileReader_Should
    {
        private IStreamReaderBuilder _streamReaderBuilder;

        private DatFileReader<int> _sut;
        
        [SetUp]
        public void Init()
        {
            _streamReaderBuilder = new StreamReaderBuilder();

            _sut = new DatFileReader<int>(_streamReaderBuilder);
        }

        [Test]
        public void Read_ReadInT32000Integers()
        {
            const string filePath = @"TestFiles\ran32000.dat";
            
            int[] result = _sut.Read(new[] { filePath });
            
            Assert.AreEqual(32000, result.Length);
        }

        [Test]
        public void Read_ReadInT32000IntegersOfTypeInt()
        {
            const string filePath = @"TestFiles\ran32000.dat";
            
            int[] result = _sut.Read(new[] { filePath });

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }

        [Test]
        public void Read_ReadInT64000Integers()
        {
            const string filePath = @"TestFiles\ran64000.dat";

            int[] result = _sut.Read(new[] { filePath });

            Assert.AreEqual(64000, result.Length);
        }

        [Test]
        public void Read_ReadInT64000IntegersOfTypeInt()
        {
            const string filePath = @"TestFiles\ran64000.dat";

            int[] result = _sut.Read(new[] { filePath });

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }

        [Test]
        public void Read_ReadInT128000Integers()
        {
            const string filePath = @"TestFiles\ran128000.dat";

            int[] result = _sut.Read(new[] { filePath });

            Assert.AreEqual(128000, result.Length);
        }

        [Test]
        public void Read_ReadInT128000IntegersOfTypeInt()
        {
            const string filePath = @"TestFiles\ran128000.dat";

            int[] result = _sut.Read(new[] { filePath });

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }

        [Test]
        public void Read_ReadInT256000Integers()
        {
            const string filePath = @"TestFiles\ran256000.dat";

            int[] result = _sut.Read(new[] { filePath });

            Assert.AreEqual(256000, result.Length);
        }

        [Test]
        public void Read_ReadInT256000IntegersOfTypeInt()
        {
            const string filePath = @"TestFiles\ran256000.dat";

            int[] result = _sut.Read(new[] { filePath });

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }

        [Test]
        public void Read_ReadInT512000Integers()
        {
            const string filePath = @"TestFiles\ran512000.dat";

            int[] result = _sut.Read(new[] { filePath });

            Assert.AreEqual(512000, result.Length);
        }

        [Test]
        public void Read_ReadInT512000IntegersOfTypeInt()
        {
            const string filePath = @"TestFiles\ran512000.dat";

            int[] result = _sut.Read(new[] { filePath });

            CollectionAssert.AllItemsAreInstancesOfType(result, typeof(int));
        }
    }
}
