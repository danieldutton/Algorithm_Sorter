namespace Sorter.Input.Interfaces
{
    public interface IFileReader<out TTypeToRead>
    {
        TTypeToRead[] Read(string[] filePaths);
    }
}
