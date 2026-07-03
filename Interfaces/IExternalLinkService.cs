namespace ConcertTrackerBlazorHybridApp.Interfaces;
public interface IExternalLinkService
{
    Task OpenExternalAsync(string url);
    Task OpenInAppAsync(string url);
}
