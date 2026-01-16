using Microsoft.AspNetCore.Mvc;
using ProductApp.Services;

namespace ProductApp.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = _productService.GetById(id);
            if (product == null)
                return NotFound();

            return View(product);
        }
    }
}
