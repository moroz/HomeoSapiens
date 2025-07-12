using DataLayer.EfClasses;

namespace HomeoSapiens.Models;

public class HomeViewModel(IEnumerable<Event> events)
{
    public IEnumerable<Event> Events { get; set; } = events;
}