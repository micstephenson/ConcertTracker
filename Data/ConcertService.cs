namespace ConcertTrackerBlazorHybridApp.Data;

public class ConcertService
{
    private readonly List<Concerts> _concerts = new();

    public IReadOnlyList<Concerts> GetAll() => _concerts.AsReadOnly();

    public IReadOnlyList<Concerts> GetAttended() =>
        _concerts.Where(c => c.Attended).ToList().AsReadOnly();

    public IReadOnlyList<Concerts> GetUpcoming() =>
        _concerts.Where(c => !c.Attended).ToList().AsReadOnly();

    public void Add(Concerts concert) => _concerts.Add(concert);
}
