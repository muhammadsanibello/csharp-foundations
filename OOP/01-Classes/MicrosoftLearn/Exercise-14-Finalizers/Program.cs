// Class finalizer

public class ResourceHolder
{
    // Unmanaged resource
    private IntPtr unmanagedResource;
    
    // Constructor
    public ResourceHolder()
    {
        // Allocate unmanaged resource
        unmanagedResource = /* allocate resource */;
    }

    // Finalizer
    ~ResourceHolder()
    {
        // Release unmanaged resource
        if (unmanagedResource != IntPtr.Zero)
        {
            // Free the resource
            /* free resourse */
            unmanagedResource = IntPtr.Zero;
        }
    }
}