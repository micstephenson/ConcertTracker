using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using ConcertTrackerBlazorHybridApp.Data;
using ConcertTrackerBlazorHybridApp.Repositories;
using ConcertTrackerBlazorHybridApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.IO;

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

            using (var appSettingsStream = FileSystem.OpenAppPackageFileAsync("appsettings.json").GetAwaiter().GetResult())
            {
                builder.Configuration.AddJsonStream(appSettingsStream);
            }

            var connectionString = builder.Configuration.GetConnectionString("ConcertsDb");
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException("Connection string 'ConcertsDb' was not found. Ensure appsettings.json is packaged and loaded.");
            }

            builder.Services.AddDbContextFactory<ConcertDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddScoped<ConcertService>();
            builder.Services.AddHttpClient("nominatim", c => c.BaseAddress = new Uri("https://nominatim.openstreetmap.org"));
            builder.Services.AddHttpClient("itunes", c => c.BaseAddress = new Uri("https://itunes.apple.com"));
            builder.Services.AddSingleton<LastFmService>();

            builder.Services
                .AddBlazorise(options => { options.Immediate = true; })
                .AddBootstrap5Providers()
                .AddFontAwesomeIcons();

            builder.Services.AddScoped<IConcertRepository, ConcertRepository>();
            builder.Services.AddScoped<IConcertService>(sp => sp.GetRequiredService<ConcertService>());

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();


#endif

            var app = builder.Build();

            return app;
        }
    }
}
