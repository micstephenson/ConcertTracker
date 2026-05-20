namespace ConcertTrackerBlazorHybridApp.Data;

public class Concerts
{
    public string Artist { get; set; }
    public string Location { get; set; }
    public DateTime Date { get; set; }
    public bool Attended { get; set; } = false;
}
