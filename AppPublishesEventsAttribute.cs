namespace Vantum.AppKit;

/// <summary>
/// Declares events that this module publishes. Apply to the module anchor class.
/// The runtime event bus should use these exact event names (case-sensitive).
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AppPublishesEventsAttribute : Attribute
{
    /// <summary>
    /// Array of event names that this module publishes (e.g., "Contact.Created", "Contact.Updated").
    /// </summary>
    public string[] Events { get; }

    /// <summary>
    /// Initializes the published events declaration.
    /// </summary>
    /// <param name="events">Event names that this module publishes.</param>
    public AppPublishesEventsAttribute(params string[] events) => Events = events;
}
