using ConcertTrackerBlazorHybridApp.DataTransferObjects;
using ConcertTrackerBlazorHybridApp.Interfaces;
using ConcertTrackerBlazorHybridApp.Mappers;
using ConcertTrackerBlazorHybridApp.Repositories;

namespace ConcertTrackerBlazorHybridApp.Services;

public class ConcertService(IConcertRepository concertRepository) : IConcertService
{
    public ConcertDto GetConcertById(int id)
    {
        var concertEntity = concertRepository.GetConcertById(id);
        return concertEntity?.ToDto();
    }

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

    public IReadOnlyList<ConcertDto> ToBeRated()
    {
        var concertentity = concertRepository.ToBeRated();
        return concertentity.ToDtoList();
    }

    public void AddRating(ConcertDto concert, int rating)
    {
        concertRepository.AddRating(concert.ToEntity(), rating);
    }

    public void Add(ConcertDto concert)
    {
        var concertEntity = concert.ToEntity();
        concertRepository.Add(concertEntity);
    }
}
