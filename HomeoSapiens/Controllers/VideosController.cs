using Microsoft.AspNetCore.Mvc;

namespace HomeoSapiens.Controllers;

public class VideosController : Controller
{
    // GET
    [Route("/watch")]
    public IActionResult Index()
    {
        return View();
    }
}