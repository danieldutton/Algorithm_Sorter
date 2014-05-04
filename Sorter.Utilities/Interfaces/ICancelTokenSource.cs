using System.Threading;

namespace Sorter.Utilities.Interfaces
{
    public interface ICancelTokenSource
    {
        CancellationToken Token { get; }
        
        void Cancel();
        
        void Dispose();
    }
}
