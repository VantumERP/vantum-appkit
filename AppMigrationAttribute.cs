namespace Vantum.AppKit;

/// <summary>
/// Marks an EF migration as belonging to a specific app.
/// Used by the manifest augmentation service to automatically discover and register migrations.
/// </summary>
/// <example>
/// <code>
/// [AppMigration("ProductInventory", "Initial inventory schema", "global")]
/// public partial class InitialInventorySchema : Migration
/// {
///     // Migration implementation
/// }
/// </code>
/// </example>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
public class AppMigrationAttribute : Attribute
{
    /// <summary>
    /// The app this migration belongs to (e.g., "ProductInventory")
    /// </summary>
    public string AppName { get; }

    /// <summary>
    /// Human-readable description of what this migration does
    /// </summary>
    public string Description { get; }

    /// <summary>
    /// Scope of the migration: "global" (shared schema) or "tenant" (tenant-specific)
    /// Default: "global"
    /// </summary>
    public string Scope { get; }

    /// <summary>
    /// Creates a new AppMigration attribute
    /// </summary>
    /// <param name="appName">The app this migration belongs to</param>
    /// <param name="description">Description of the migration</param>
    /// <param name="scope">Migration scope: "global" or "tenant" (default: "global")</param>
    public AppMigrationAttribute(string appName, string description, string scope = "global")
    {
        AppName = appName;
        Description = description;
        Scope = scope;
    }
}
