namespace Vantum.AppKit;

[AttributeUsage(AttributeTargets.Class, Inherited = false)]
public sealed class AppModuleAttribute : Attribute
{
    public string Name { get; }
    public string DisplayName { get; set; } = "";
    public string Version { get; set; } = "0.1.0";
    public string? Description { get; set; }
    public AppModuleAttribute(string name) => Name = name;
}