using System.Threading;

namespace Sorter.Utilities.Async
{
    public class CancellationTokenSourceWrapper : ICancellationTokenSource
    {
        private readonly CancellationTokenSource _source;

        public CancellationToken Token
        {
            get { return _source.Token; }
        }


        public CancellationTokenSourceWrapper(CancellationTokenSource source)
        {
            _source = source;
        }

        public void Cancel()
        {
            _source.Cancel();
        }

        public void Dispose()
        {
            _source.Dispose();
        }

    }
}
