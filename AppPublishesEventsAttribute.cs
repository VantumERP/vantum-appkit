namespace Vantum.AppKit;

/// <summary>
/// Declares events that this module publishes. Apply to the module anchor class or individual route methods.
/// The Vantum CLI will extract these and add them to backend.events.published[] in the manifest.
/// The runtime event bus should use these exact event names (case-sensitive).
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public sealed class AppPublishesEventsAttribute : Attribute
{
    /// <summary>
    /// Array of event names that this module/route publishes (e.g., "Contact.Created", "Contact.Updated").
    /// </summary>
    public string[] Events { get; }

    /// <summary>
    /// Initializes the published events declaration.
    /// </summary>
    /// <param name="events">Event names that this module/route publishes.</param>
    public AppPublishesEventsAttribute(params string[] events) => Events = events;
}
