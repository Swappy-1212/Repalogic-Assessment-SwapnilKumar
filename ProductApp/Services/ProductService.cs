using System.Text.Json;
using ProductApp.Models;

namespace ProductApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IWebHostEnvironment _env;

        public ProductService(IWebHostEnvironment env)
        {
            _env = env;
        }

        public IEnumerable<Product> GetAll()
        {
            var path = Path.Combine(_env.ContentRootPath, "Data", "products.json");
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
        }

        public Product? GetById(int id)
        {
            return GetAll().FirstOrDefault(p => p.Id == id);
        }
    }
}
