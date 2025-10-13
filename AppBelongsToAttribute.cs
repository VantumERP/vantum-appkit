namespace Vantum.AppKit;

/// <summary>
/// Marks a controller as belonging to a specific module.
/// The generator will scan all controllers with this attribute and include their routes in the module's manifest.
/// </summary>
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public sealed class AppBelongsToAttribute : Attribute
{
    /// <summary>
    /// The name of the module this controller belongs to (must match an [AppModule] Name).
    /// </summary>
    public string ModuleName { get; }

    /// <summary>
    /// Initializes a new controller-to-module binding.
    /// </summary>
    /// <param name="moduleName">The module name (must match an [AppModule] Name).</param>
    public AppBelongsToAttribute(string moduleName)
    {
        ModuleName = moduleName;
    }
}
