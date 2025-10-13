namespace Vantum.AppKit;

/// <summary>
/// Optional lifecycle hooks that modules can implement to handle
/// install, upgrade, and uninstall events.
/// </summary>
public interface IAppLifecycle
{
    /// <summary>
    /// Called when the module is first installed.
    /// </summary>
    Task OnInstallAsync(CancellationToken ct);

    /// <summary>
    /// Called when the module is upgraded from one version to another.
    /// </summary>
    /// <param name="fromVersion">The previous version being upgraded from.</param>
    /// <param name="ct">Cancellation token.</param>
    Task OnUpgradeAsync(string fromVersion, CancellationToken ct);

    /// <summary>
    /// Called when the module is uninstalled.
    /// </summary>
    Task OnUninstallAsync(CancellationToken ct);
}
