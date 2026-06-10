using ConcertTrackerBlazorHybridApp.Data.Entities;
using ConcertTrackerBlazorHybridApp.DataTransferObjects;

namespace ConcertTrackerBlazorHybridApp.Services;

public interface IConcertService
{
    public IReadOnlyList<ConcertDto> GetAll();
    public IReadOnlyList<ConcertDto> GetAttended();
    public IReadOnlyList<ConcertDto> GetUpcoming();
    public void Add(ConcertDto concert);
}
