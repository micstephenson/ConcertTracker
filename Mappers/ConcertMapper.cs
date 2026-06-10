using ConcertTrackerBlazorHybridApp.Data.Entities;
using ConcertTrackerBlazorHybridApp.DataTransferObjects;

namespace ConcertTrackerBlazorHybridApp.Mappers;

public static class ConcertMapper
{
    public static ConcertDto ToDto(this Concerts entity)
    {
        return new ConcertDto
        {
            Artist = entity?.artist,
            Venue = entity?.venue,
            City = entity?.city,
            Date = entity?.concert_date,
            Attended = entity?.attended ?? false,
            Rating = entity?.rating ?? 0
        };
    }

    public static IReadOnlyList<ConcertDto> ToDtoList(this IEnumerable<Concerts> concerts)
        => concerts.Select(c => c.ToDto()).ToList();
        
    public static Concerts ToEntity(this ConcertDto dto)
    {
        return new Concerts
        {
            artist = dto?.Artist,
            venue = dto?.Venue,
            city = dto?.City,
            concert_date = dto?.Date,
            attended = dto?.Attended ?? false,
            rating = dto?.Rating ?? 0
        };
    }
        
}
