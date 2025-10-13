namespace Vantum.AppKit;

/// <summary>
/// Marks a class as a module anchor. Each module should have exactly one anchor class
/// that defines the module's metadata. The generator will scan for this attribute to
/// discover modules and their associated controllers/routes.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class AppModuleAttribute : Attribute
{
    /// <summary>
    /// Unique identifier for the module (e.g., "Contacts", "Inventory").
    /// </summary>
    public string Name { get; init; } = "";

    /// <summary>
    /// Human-readable display name for the module.
    /// </summary>
    public string DisplayName { get; init; } = "";

    /// <summary>
    /// Semantic version of the module (e.g., "1.2.3").
    /// </summary>
    public string Version { get; init; } = "0.1.0";

    /// <summary>
    /// Optional description of the module's functionality.
    /// </summary>
    public string? Description { get; init; }
}
