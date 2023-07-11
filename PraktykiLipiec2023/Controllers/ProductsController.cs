using Microsoft.AspNetCore.Mvc;
using PraktykiLipiec2023.Repositories;

namespace PraktykiLipiec2023.Controllers;

public class ProductsController : Controller
{
    private readonly IProductsRepository _productRepository;
    
    public ProductsController(IProductsRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    [HttpGet]
    public IActionResult Index()
    {
        var model = _productRepository.List();
        return View(model);
    }
}