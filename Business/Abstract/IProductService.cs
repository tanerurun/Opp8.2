using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByProductId(int productId);
        List<Product> GetByProductName(string productName);
        List<Product> GetByProductPrice(decimal min, decimal max);

    }
}
