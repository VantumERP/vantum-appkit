namespace Vantum.AppKit;

/// <summary>
/// Explicitly declares a route in the module manifest (Pattern A - manual declaration).
/// For auto-inference from MVC attributes, use [AppRouteAuto] instead (Pattern B).
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class AppRouteAttribute : Attribute
{
    /// <summary>
    /// HTTP method (GET, POST, PUT, DELETE, PATCH).
    /// </summary>
    public string Method { get; }

    /// <summary>
    /// Route path (e.g., "/api/contacts/{id}").
    /// </summary>
    public string Path { get; }

    /// <summary>
    /// Optional permission required to access this route.
    /// </summary>
    public string? RequiredPermission { get; set; }

    /// <summary>
    /// Initializes a new route declaration.
    /// </summary>
    /// <param name="method">HTTP method (GET, POST, PUT, DELETE, PATCH).</param>
    /// <param name="path">Route path (e.g., "/api/contacts/{id}").</param>
    public AppRouteAttribute(string method, string path)
        => (Method, Path) = (method, path);
}
