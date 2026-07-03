using ConcertTrackerBlazorHybridApp.Interfaces;

namespace ConcertTrackerBlazorHybridApp.Services;

public class ExternalLinkService : IExternalLinkService
{
    public Task OpenExternalAsync(string url)
        => Launcher.Default.OpenAsync(new Uri(url));

    public Task OpenInAppAsync(string url)
        => MainThread.InvokeOnMainThreadAsync(async () =>
        {
            var hostPage = Application.Current?.Windows[0].Page;
            if (hostPage is null) return;

            await hostPage.Navigation.PushModalAsync(
                new NavigationPage(new ExternalWebpage(url)));
        });
}
