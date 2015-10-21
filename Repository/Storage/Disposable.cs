using System;

namespace Repository.Storage
{
    public class Disposable : IDisposable
    {
        public bool IsDisposed { get; private set; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            IsDisposed = true;
        }

        ~Disposable()
        {
            Dispose(false);
        }
    }
}