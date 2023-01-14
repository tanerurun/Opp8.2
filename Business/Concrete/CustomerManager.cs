using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public List<Customer> GetAll()
        {
            return _customerDal.GetAll();
        }

        public List<Customer> GetByCustomerId(string customerId)
        {
            return _customerDal.GetAll(p => p.CustomerId == customerId).ToList();
        }

        public List<Customer> GetByCustomerName(string customerName)
        {
            return _customerDal.GetAll(p => p.ContactName == customerName).ToList();
        }
    }
}
