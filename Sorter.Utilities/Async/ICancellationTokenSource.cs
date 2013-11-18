using System.Threading;

namespace Sorter.Utilities.Async
{
    public interface ICancellationTokenSource
    {
        CancellationToken Token { get; }

        void Cancel();

        void Dispose();
    }
}
