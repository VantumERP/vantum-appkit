namespace Vantum.AppKit;

/// <summary>
/// Declares events that this module subscribes to (listens for). Apply to the module anchor class or Wolverine message handlers.
/// The Vantum CLI will extract these and add them to backend.events.subscribed[] in the manifest.
/// The runtime event bus should use these exact event names (case-sensitive).
/// </summary>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true)]
public sealed class AppSubscribesEventsAttribute : Attribute
{
    /// <summary>
    /// Array of event names that this module/handler subscribes to (e.g., "Company.Created", "User.Updated").
    /// </summary>
    public string[] Events { get; }

    /// <summary>
    /// Initializes the subscribed events declaration.
    /// </summary>
    /// <param name="events">Event names that this module/handler subscribes to.</param>
    public AppSubscribesEventsAttribute(params string[] events) => Events = events;
}
