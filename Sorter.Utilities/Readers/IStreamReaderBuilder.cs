using System.IO;

namespace Sorter.Utilities.Readers
{
    public interface IStreamReaderBuilder
    {
        StreamReader StreamReader { get; }

        void BuildStreamReader(string filePath);
    }
}
