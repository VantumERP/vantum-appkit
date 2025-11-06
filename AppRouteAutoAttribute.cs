namespace Vantum.AppKit;

/// <summary>
/// Marks a controller action for auto-inference in the app manifest.
/// The Vantum CLI will read ASP.NET Core MVC attributes ([HttpGet], [Route], etc.) to infer the HTTP method and path,
/// and use this attribute to extract permissions and events for the manifest.
/// </summary>
[AttributeUsage(AttributeTargets.Method)]
public sealed class AppRouteAutoAttribute : Attribute
{
    /// <summary>
    /// The permissions required to access this route (e.g., ["Contacts.Read", "Contacts.Export"]).
    /// Multiple permissions mean the user must have ALL of them (AND logic).
    /// </summary>
    public string[] RequiredPermissions { get; init; } = Array.Empty<string>();

    /// <summary>
    /// Optional: events that this route may publish (e.g., ["Contact.Created", "Contact.Updated"]).
    /// </summary>
    public string[]? PublishesEvents { get; init; }

    /// <summary>
    /// Optional: override the HTTP method if it cannot be inferred from MVC attributes.
    /// If not set, the CLI will use [HttpGet]/[HttpPost]/etc.
    /// </summary>
    public string? MethodOverride { get; init; }

    /// <summary>
    /// Optional: override the entire path if you don't want auto-inference.
    /// If not set, the CLI will combine controller [Route] + action template.
    /// </summary>
    public string? PathOverride { get; init; }
}
