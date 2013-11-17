using System.IO;

namespace Sorter.Utilities.Readers
{
    public class StreamReaderBuilder : IStreamReaderBuilder
    {
        public StreamReader StreamReader { get; private set; }

        public void BuildStreamReader(string filePath)
        {
            StreamReader = new StreamReader(filePath);
        }
    }
}
