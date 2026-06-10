namespace ConcertTrackerBlazorHybridApp.Data.Entities;

using System.ComponentModel.DataAnnotations;

public class Concerts
{
    [Key]
    public int concertId { get; set; }
    public string? artist { get; set; }
    public string? venue { get; set; }
    public string? city { get; set; }
    public DateTime? concert_date { get; set; }
    public bool attended { get; set; } = false;
    public int? rating { get; set; } = null;
}
