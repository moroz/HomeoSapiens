using HomeoSapiens.Database.Models;
using HomeoSapiens.Domain;
using Microsoft.EntityFrameworkCore;

namespace HomeoSapiens.Database.Repositories;

public class EventRepository(AppDbContext context) : IEventRepository
{
    public async Task<IEnumerable<Event>> GetAllAsync()
    {
        return await context.Events.AsNoTracking()
            .OrderByDescending(e => e.Id)
            .ToListAsync();
    }

    public async Task<IEnumerable<Event>> GetFeaturedAsync()
    {
        return await context.Events.AsNoTracking()
            .OrderByDescending(e => e.Id)
            .Take(1)
            .ToListAsync();
    }
}