namespace Vantum.AppKit;

/// <summary>
/// Marks a controller action for auto-inference in the app manifest.
/// The generator will read ASP.NET Core MVC attributes ([HttpGet], [Route], etc.) to infer the HTTP method and path.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class AppRouteAutoAttribute : Attribute
{
    /// <summary>
    /// The permission required to access this route (e.g., "Contacts.Read").
    /// </summary>
    public string? RequiredPermission { get; init; }

    /// <summary>
    /// Optional: override the HTTP method if it cannot be inferred from MVC attributes.
    /// If not set, the generator will use [HttpGet]/[HttpPost]/etc.
    /// </summary>
    public string? MethodOverride { get; init; }

    /// <summary>
    /// Optional: override the entire path if you don't want auto-inference.
    /// If not set, the generator will combine controller [Route] + action template.
    /// </summary>
    public string? PathOverride { get; init; }
}
