using HomeoSapiens.Database.Models;

namespace HomeoSapiens.Models;

public class VideoViewModel
{
    public IEnumerable<Video> Videos { get; set; } = new List<Video>();
}