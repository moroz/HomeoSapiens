using DataLayer.EfClasses;

namespace HomeoSapiens.Models;

public class HomeViewModel
{
    public IEnumerable<Event> Events { get; set; }
}