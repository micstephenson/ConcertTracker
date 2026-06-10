using ConcertTrackerBlazorHybridApp.Data.Entities;

namespace ConcertTrackerBlazorHybridApp.Repositories;

public interface IConcertRepository
{
    public Concerts GetConcertById(int id);
    IReadOnlyList<Concerts> GetAll();
    IReadOnlyList<Concerts> GetAttended();
    IReadOnlyList<Concerts> GetUpcoming();
    IReadOnlyList<Concerts> ToBeRated();
    public void AddRating(Concerts concert, int rating);
    void Add(Concerts concert);
}
