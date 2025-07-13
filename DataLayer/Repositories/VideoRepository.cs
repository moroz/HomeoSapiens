using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.EfClasses;
using DataLayer.EfCode;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories;

public class VideoRepository(AppDbContext context) : IVideoRepository
{
    public async Task<IEnumerable<Video>> GetAllAsync()
    {
        return await context.Videos.AsNoTracking()
            .OrderByDescending(e => e.Id)
            .ToListAsync();
    }
}