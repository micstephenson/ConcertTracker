namespace ConcertTrackerBlazorHybridApp.DataTransferObjects;

public class ConcertDto
{
    public string? Artist { get; set; } = string.Empty;
    public string? Venue { get; set; } = string.Empty;
    public string? City { get; set; } = string.Empty;
    public DateTime? Date { get; set; }
    public bool Attended { get; set; }
    public int? Rating { get; set; }
}
