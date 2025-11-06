namespace Vantum.AppKit;

/// <summary>
/// Declares module-level permissions. Apply to the module anchor class to define
/// all permissions that the module provides. These will be extracted by the Vantum CLI
/// and added to the manifest's permissions.scopes[] array.
/// Note: Permissions on routes (via [AppRouteAuto]) are also auto-extracted.
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AppPermissionsAttribute : Attribute
{
    /// <summary>
    /// Array of permission identifiers (e.g., "Contacts.Read", "Contacts.Write").
    /// </summary>
    public string[] Permissions { get; }

    /// <summary>
    /// Initializes the permissions for a module.
    /// </summary>
    /// <param name="permissions">Permission identifiers.</param>
    public AppPermissionsAttribute(params string[] permissions) => Permissions = permissions;
}
