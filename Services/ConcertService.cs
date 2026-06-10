using ConcertTrackerBlazorHybridApp.DataTransferObjects;
using ConcertTrackerBlazorHybridApp.Data.Entities;
using ConcertTrackerBlazorHybridApp.Mappers;
using ConcertTrackerBlazorHybridApp.Repositories;

namespace ConcertTrackerBlazorHybridApp.Services;

public class ConcertService(IConcertRepository concertRepository) : IConcertService
{
    public IReadOnlyList<ConcertDto> GetAll()
    {
        var concertentity = concertRepository.GetAll();
        return concertentity.ToDtoList();
    }

    public IReadOnlyList<ConcertDto> GetAttended()
    {
        var concertentity = concertRepository.GetAttended();
        return concertentity.ToDtoList();
    }

    public IReadOnlyList<ConcertDto> GetUpcoming()
    {
        var concertentity = concertRepository.GetUpcoming();
        return concertentity.ToDtoList();
    }

    public void Add(ConcertDto concert)
    {
        var concertEntity = concert.ToEntity();
        concertRepository.Add(concertEntity);
    }
}
