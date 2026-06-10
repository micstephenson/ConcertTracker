using ConcertTrackerBlazorHybridApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace ConcertTrackerBlazorHybridApp.Data;

public class ConcertDbContext : DbContext
{
    public ConcertDbContext(DbContextOptions<ConcertDbContext> options) : base(options) { }

    public DbSet<Concerts> Concert { get; set; }
}
