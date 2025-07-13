using System.Diagnostics;
using DataLayer.Repositories;
using HomeoSapiens.Models;
using Microsoft.AspNetCore.Mvc;

namespace HomeoSapiens.Controllers;

public class HomeController(IEventRepository eventRepository)
    : Controller
{
    public async Task<IActionResult> Index()
    {
        var events = await eventRepository.GetFeaturedAsync();
        return View(new HomeViewModel { Events = events });
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}