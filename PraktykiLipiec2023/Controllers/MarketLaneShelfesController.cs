using Microsoft.AspNetCore.Mvc;

namespace PraktykiLipiec2023.Controllers;

public class MarketLaneShelfesController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}