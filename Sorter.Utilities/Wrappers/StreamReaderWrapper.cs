using Sorter.Utilities.Interfaces;
using System.IO;

namespace Sorter.Utilities.Wrappers
{
    public class StreamReaderWrapper : IStreamReaderBuilder
    {
        public StreamReader StreamReader { get; private set; }

        public void BuildStreamReader(string filePath)
        {
            StreamReader = new StreamReader(filePath);
        }
    }
}
