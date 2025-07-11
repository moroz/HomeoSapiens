using Microsoft.EntityFrameworkCore;
using DataLayer.EfClasses;

namespace DataLayer.EfCode;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Event> Events { get; set; }
}