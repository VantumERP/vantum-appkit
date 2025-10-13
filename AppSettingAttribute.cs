namespace Vantum.AppKit;

/// <summary>
/// Declares a configurable setting for a module. Apply to fields or properties
/// on the module anchor class.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = true)]
public sealed class AppSettingAttribute : Attribute
{
    /// <summary>
    /// Unique key for the setting (e.g., "DefaultCurrency", "MaxResults").
    /// </summary>
    public string Key { get; }

    /// <summary>
    /// Data type of the setting value.
    /// </summary>
    public AppSettingType SettingType { get; }

    /// <summary>
    /// Optional default value for the setting.
    /// </summary>
    public object? DefaultValue { get; set; }

    /// <summary>
    /// Optional description of the setting's purpose.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Initializes a new setting declaration.
    /// </summary>
    /// <param name="key">Unique setting key.</param>
    /// <param name="settingType">Data type of the setting.</param>
    public AppSettingAttribute(string key, AppSettingType settingType)
        => (Key, SettingType) = (key, settingType);
}
