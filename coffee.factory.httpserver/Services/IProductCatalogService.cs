using coffee.factory.httpserver.Models;

namespace coffee.factory.httpserver.Services
{
    public interface IProductCatalogService
    {
        double GetPrice(object product);
    }
}
