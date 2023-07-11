using Microsoft.AspNetCore.Mvc;

namespace PraktykiLipiec2023.Controllers;

public class ProductCategoressController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}