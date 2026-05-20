using System.Text.Json;

namespace ConcertTrackerBlazorHybridApp.Data;

public class LastFmService
{
    private readonly IHttpClientFactory _httpFactory;
    private readonly Dictionary<string, string?> _cache = new();

    public LastFmService(IHttpClientFactory httpFactory)
    {
        _httpFactory = httpFactory;
    }

    public async Task<string?> GetArtistImageUrlAsync(string artistName)
    {
        if (_cache.TryGetValue(artistName, out var cached))
            return cached;

        try
        {
            var http = _httpFactory.CreateClient("itunes");
            var response = await http.GetStringAsync(
                $"/search?term={Uri.EscapeDataString(artistName)}&media=music&entity=musicArtist&limit=1");

            using var doc = JsonDocument.Parse(response);
            var results = doc.RootElement.GetProperty("results");
            if (results.GetArrayLength() == 0)
            {
                _cache[artistName] = null;
                return null;
            }

            var artworkUrl = results[0].GetProperty("artworkUrl100").GetString()
                ?.Replace("100x100", "600x600");

            _cache[artistName] = artworkUrl;
            return artworkUrl;
        }
        catch
        {
            _cache[artistName] = null;
            return null;
        }
    }
}
