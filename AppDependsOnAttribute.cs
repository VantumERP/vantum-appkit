namespace Vantum.AppKit;

/// <summary>
/// Declares a dependency on another module. Apply to the module anchor class (can use multiple times).
/// The version range follows NuGet/npm-style versioning (e.g., ">=1.0 &lt;2.0", "^1.0", "~1.2.3").
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AppDependsOnAttribute : Attribute
{
    /// <summary>
    /// The name of the module this module depends on.
    /// </summary>
    public string AppName { get; }

    /// <summary>
    /// The acceptable version range for the dependency.
    /// Supports NuGet-style ranges: ">=1.0 &lt;2.0", "^1.0" (compatible), "~1.2.3" (patch-level).
    /// </summary>
    public string VersionRange { get; }

    /// <summary>
    /// Initializes a new dependency declaration.
    /// </summary>
    /// <param name="appName">The name of the module this module depends on.</param>
    /// <param name="versionRange">The acceptable version range (NuGet-style: ">=1.0 &lt;2.0", "^1.0", "~1.2.3").</param>
    public AppDependsOnAttribute(string appName, string versionRange)
    {
        AppName = appName;
        VersionRange = versionRange;
    }
}
