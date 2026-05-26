public class ResourceHolder : IDisposable
{
    private bool _disposed = false;

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this); // Prevents the garbage collector from calling the finalizer if Dispose has already been called.

    }

    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Free managed resources
            }
            // Free unmanaged resources
            _disposed = true;
        }
    }

    ~ResourceHolder()
    {
        Dispose(false);
    }
}