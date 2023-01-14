using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        List<Customer> GetByCustomerId(string customerId);
        List<Customer> GetByCustomerName(string customerName);

    }
}
