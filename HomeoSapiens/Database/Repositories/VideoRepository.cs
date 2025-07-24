using HomeoSapiens.Database.Models;
using HomeoSapiens.Domain;
using Microsoft.EntityFrameworkCore;

namespace HomeoSapiens.Database.Repositories;

public class VideoRepository(AppDbContext context) : IVideoRepository
{
    public async Task<IEnumerable<Video>> GetAllAsync()
    {
        return await context.Videos.AsNoTracking()
            .OrderByDescending(e => e.Id)
            .ToListAsync();
    }
}