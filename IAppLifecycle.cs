public interface IAppLifecycle
{
    Task OnInstallAsync(CancellationToken ct);
    Task OnUpgradeAsync(string fromVersion, CancellationToken ct);
    Task OnUninstallAsync(CancellationToken ct);
}