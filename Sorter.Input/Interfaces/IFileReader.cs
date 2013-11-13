namespace Sorter.Input.Interfaces
{
    public interface IFileReader<out TTypeToRead>
    {
        TTypeToRead[] Read(params string[] filePaths);
    }
}
