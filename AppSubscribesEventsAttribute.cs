namespace Vantum.AppKit;

/// <summary>
/// Declares events that this module subscribes to (listens for). Apply to the module anchor class.
/// The runtime event bus should use these exact event names (case-sensitive).
/// </summary>
[AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
public sealed class AppSubscribesEventsAttribute : Attribute
{
    /// <summary>
    /// Array of event names that this module subscribes to (e.g., "Company.Created", "User.Updated").
    /// </summary>
    public string[] Events { get; }

    /// <summary>
    /// Initializes the subscribed events declaration.
    /// </summary>
    /// <param name="events">Event names that this module subscribes to.</param>
    public AppSubscribesEventsAttribute(params string[] events) => Events = events;
}
