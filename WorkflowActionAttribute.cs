namespace Vantum.AppKit;

/// <summary>
/// Marks a method as a custom app action that can be used in workflows.
/// This allows workflows to invoke app-specific business logic.
/// </summary>
[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
public sealed class WorkflowActionAttribute : Attribute
{
    /// <summary>
    /// Unique action key (e.g., "send-welcome-email", "calculate-discount")
    /// </summary>
    public string ActionKey { get; }

    /// <summary>
    /// Human-readable action name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Action description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Category for grouping actions
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Permissions required to execute this action
    /// </summary>
    public string[]? RequiredPermissions { get; set; }

    /// <summary>
    /// Expected input parameter types (for validation and UI generation)
    /// </summary>
    public Type[]? InputTypes { get; set; }

    /// <summary>
    /// Expected output type (for validation and workflow chaining)
    /// </summary>
    public Type? OutputType { get; set; }

    public WorkflowActionAttribute(string actionKey)
    {
        ActionKey = actionKey ?? throw new ArgumentNullException(nameof(actionKey));
    }
}
