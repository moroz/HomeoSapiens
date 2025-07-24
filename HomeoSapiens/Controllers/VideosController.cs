using HomeoSapiens.Domain;
using HomeoSapiens.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeoSapiens.Controllers;

public class VideosController(IVideoRepository videoRepository) : Controller
{
    // GET
    [Route("/watch")]
    public async Task<IActionResult> Index()
    {
        var videos = await videoRepository.GetAllAsync();
        return View(new VideoViewModel { Videos = videos });
    }
}