using ConcertTrackerBlazorHybridApp.Data;
using ConcertTrackerBlazorHybridApp.Data.Entities;

namespace ConcertTrackerBlazorHybridApp.Repositories;

public class ConcertRepository(ConcertDbContext context) : IConcertRepository
{
    public IReadOnlyList<Concerts> GetAll()
    {
        var concerts = context.Concert.ToList();
        return concerts;
    }

    public IReadOnlyList<Concerts> GetAttended()
    {
        var concerts = context.Concert.Where(c => c.attended).ToList();
        return concerts;
    }

    public IReadOnlyList<Concerts> GetUpcoming()
    {
        var concerts = context.Concert.Where(c => !c.attended).ToList();
        return concerts;
    }

    public void Add(Concerts concert)
    {
        context.Concert.Add(concert);
        context.SaveChanges();
    }
}
