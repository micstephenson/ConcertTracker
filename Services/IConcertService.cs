using ConcertTrackerBlazorHybridApp.Data.Entities;
using ConcertTrackerBlazorHybridApp.DataTransferObjects;

namespace ConcertTrackerBlazorHybridApp.Services;

public interface IConcertService
{
    public ConcertDto GetConcertById(int id);
    public IReadOnlyList<ConcertDto> GetAll();
    public IReadOnlyList<ConcertDto> GetAttended();
    public IReadOnlyList<ConcertDto> GetUpcoming();
    public IReadOnlyList<ConcertDto> ToBeRated();
    public void AddRating(ConcertDto concert, int rating);
    public void Add(ConcertDto concert);
}
