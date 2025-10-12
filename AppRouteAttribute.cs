namespace Vantum.AppKit;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class AppRouteAttribute : Attribute
{
    public string Method { get; }
    public string Path { get; }
    public string? RequiredPermission { get; set; }
    public AppRouteAttribute(string method, string path)
        => (Method, Path) = (method, path);
}