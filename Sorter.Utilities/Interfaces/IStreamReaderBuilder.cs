using System.IO;

namespace Sorter.Utilities.Interfaces
{
    public interface IStreamReaderBuilder
    {
        StreamReader StreamReader { get; }

        void BuildStreamReader(string filePath);
    }
}
