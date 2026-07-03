namespace ConcertTrackerBlazorHybridApp.Services;

public sealed class ExternalWebpage : ContentPage
{
    public ExternalWebpage(string url)
    {
        Title = "Browser";

        Content = new WebView
        {
            Source = url
        };

        ToolbarItems.Add(new ToolbarItem("Close", null, async () =>
        {
            await Navigation.PopModalAsync();
        }));
    }
}
