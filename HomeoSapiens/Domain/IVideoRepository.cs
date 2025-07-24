using HomeoSapiens.Database.Models;

namespace HomeoSapiens.Domain;

public interface IVideoRepository
{
    Task<IEnumerable<Video>> GetAllAsync();
}