using ConcertTrackerBlazorHybridApp.Data.Entities;

namespace ConcertTrackerBlazorHybridApp.Repositories;

public interface IConcertRepository
{
    IReadOnlyList<Concerts> GetAll();
    IReadOnlyList<Concerts> GetAttended();
    IReadOnlyList<Concerts> GetUpcoming();
    void Add(Concerts concert);
}
