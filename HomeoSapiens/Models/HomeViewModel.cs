using HomeoSapiens.Database.Models;

namespace HomeoSapiens.Models;

public class HomeViewModel
{
    public IEnumerable<Event> Events { get; set; }
}