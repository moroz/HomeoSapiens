using Microsoft.EntityFrameworkCore;

namespace DataLayer.EfCode;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
}