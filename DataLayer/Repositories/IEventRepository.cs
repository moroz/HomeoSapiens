using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer.EfClasses;

namespace DataLayer.Repositories;

public interface IEventRepository
{
    Task<IEnumerable<Event>> GetAllAsync();
    Task<IEnumerable<Event>> GetFeaturedAsync();
}