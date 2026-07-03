using ConcertTrackerBlazorHybridApp.Data;
using ConcertTrackerBlazorHybridApp.Data.Entities;

namespace ConcertTrackerBlazorHybridApp.Repositories;

public class ConcertRepository(ConcertDbContext context) : IConcertRepository
{
    public Concerts GetConcertById(int id)
    {
        var concert = context.Concert.FirstOrDefault(c => c.concertId == id);
        return concert;
    }

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
        var concerts = context.Concert.Where(c => c.concert_date > DateTime.Now).ToList();
        return concerts;
    }

    public IReadOnlyList<Concerts> ToBeRated()
    {
        var concerts = context.Concert.Where(c => c.concert_date < DateTime.Now && (c.attended == false || c.rating == null)).ToList();
        return concerts;
    }

    public void AddRating(Concerts concert, int rating)
    {
        if (concert == null)
        {
            return;
        }

        var currentConcert = context.Concert.FirstOrDefault(c => c.concertId == concert.concertId);
        if (currentConcert != null)
        {
            currentConcert.rating = rating;
            currentConcert.attended = true;
            context.SaveChanges();
        }
    }

    public void Add(Concerts concert)
    {
        context.Concert.Add(concert);
        context.SaveChanges();
    }
}
