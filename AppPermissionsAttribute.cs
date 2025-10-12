namespace Vantum.AppKit;

[AttributeUsage(AttributeTargets.Class)]
public sealed class AppPermissionsAttribute : Attribute
{
    public string[] Permissions { get; }
    public AppPermissionsAttribute(params string[] permissions) => Permissions = permissions;
}