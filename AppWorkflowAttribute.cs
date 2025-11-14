namespace Vantum.AppKit;

/// <summary>
/// Marks a class as defining a workflow for manifest discovery.
/// Use on workflow definition classes or methods that should be automatically discovered.
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = false)]
public sealed class AppWorkflowAttribute : Attribute
{
    /// <summary>
    /// Unique workflow key within the app (e.g., "contact-created-notification")
    /// </summary>
    public string WorkflowKey { get; }

    /// <summary>
    /// Human-readable workflow name
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Workflow description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Event that triggers this workflow
    /// </summary>
    public string TriggerEvent { get; set; } = string.Empty;

    /// <summary>
    /// Workflow category for organization
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// Whether this workflow is enabled by default
    /// </summary>
    public bool Enabled { get; set; } = true;

    /// <summary>
    /// Permissions required to execute this workflow
    /// </summary>
    public string[]? RequiredPermissions { get; set; }

    public AppWorkflowAttribute(string workflowKey)
    {
        WorkflowKey = workflowKey ?? throw new ArgumentNullException(nameof(workflowKey));
    }
}
