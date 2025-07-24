using HomeoSapiens.Database.Models;

namespace HomeoSapiens.Domain;

public interface IEventRepository
{
    Task<IEnumerable<Event>> GetAllAsync();
    Task<IEnumerable<Event>> GetFeaturedAsync();
}