using Microsoft.AspNetCore.Mvc;

namespace PraktykiLipiec2023.Controllers;

public class MarketLanesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}