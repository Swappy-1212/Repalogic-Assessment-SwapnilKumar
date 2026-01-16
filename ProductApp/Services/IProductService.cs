using ProductApp.Models;

namespace ProductApp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product? GetById(int id);
    }
}
