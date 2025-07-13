using System.Collections.Generic;
using System.Threading.Tasks;
using DataLayer.EfClasses;

namespace DataLayer.Repositories;

public interface IVideoRepository
{
    Task<IEnumerable<Video>> GetAllAsync();
}