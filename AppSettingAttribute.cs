namespace Vantum.AppKit;

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
public sealed class AppSettingAttribute : Attribute
{
    public string Key { get; }
    public AppSettingType SettingType { get; }
    public object? DefaultValue { get; set; }
    public string? Description { get; set; }
    public AppSettingAttribute(string key, AppSettingType settingType)
        => (Key, SettingType) = (key, settingType);
}