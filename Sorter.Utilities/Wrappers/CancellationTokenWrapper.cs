using Sorter.Utilities.Interfaces;
using System.Threading;

namespace Sorter.Utilities.Wrappers
{
    public class CancellationTokenWrapper : ICancelTokenSource
    {
        private readonly CancellationTokenSource _source;

        public CancellationToken Token
        {
            get { return _source.Token; }
        }


        public CancellationTokenWrapper(CancellationTokenSource source)
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
