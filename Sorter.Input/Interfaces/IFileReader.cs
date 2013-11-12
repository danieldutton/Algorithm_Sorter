namespace Sorter.Input.Interfaces
{
    public interface IFileReader<out TType>
    {
        TType[] Read(params string[] filePaths);
    }
}
