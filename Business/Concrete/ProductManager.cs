using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByProductId(int productId)
        {
            return _productDal.GetAll(p => p.ProductId == productId).ToList();
        }

        public List<Product> GetByProductName(string productName)
        {
            return _productDal.GetAll(p => p.ProductName == productName).ToList();
        }

        public List<Product> GetByProductPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice > min && p.UnitPrice < max).ToList();
        }
    }
}
