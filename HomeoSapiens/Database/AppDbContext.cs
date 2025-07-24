using HomeoSapiens.Database.Models;
using Microsoft.EntityFrameworkCore;

namespace HomeoSapiens.Database;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Event> Events { get; set; }
    public DbSet<Video> Videos { get; set; }
}