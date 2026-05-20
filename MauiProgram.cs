using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using ConcertTrackerBlazorHybridApp.Data;
using Microsoft.Extensions.Logging;

namespace ConcertTrackerBlazorHybridApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
            builder.Services.AddSingleton<ConcertService>();
            builder.Services.AddHttpClient("nominatim", c => c.BaseAddress = new Uri("https://nominatim.openstreetmap.org"));
            builder.Services.AddHttpClient("itunes", c => c.BaseAddress = new Uri("https://itunes.apple.com"));
            builder.Services.AddSingleton<LastFmService>();

            builder.Services
                .AddBlazorise(options => { options.Immediate = true; })
                .AddBootstrap5Providers()
                .AddFontAwesomeIcons();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();


#endif

            return builder.Build();
        }
    }
}
