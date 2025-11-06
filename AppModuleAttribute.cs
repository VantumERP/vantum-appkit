namespace Vantum.AppKit;

/// <summary>
/// Marks a class as a module anchor. Each module should have exactly one anchor class.
/// The Vantum CLI will scan for this attribute to discover modules and their associated controllers/routes.
/// Basic module metadata (name, displayName, description, version) should be defined in the manifest.json
/// created via 'vantum create-app' command. This attribute is optional and used primarily for code documentation.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class AppModuleAttribute : Attribute
{
    /// <summary>
    /// Optional: module identifier. If not provided, CLI will infer from directory/manifest.
    /// </summary>
    public string? Name { get; init; }
}
