using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.EfClasses;
using DataLayer.EfCode;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories;

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