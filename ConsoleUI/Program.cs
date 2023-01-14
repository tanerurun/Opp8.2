using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

internal class Program
{
    private static void Main(string[] args)
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        ProductManager productManager = new ProductManager(new EfProductDal());
        UserManager userManager = new UserManager(new EfUserDal());


        foreach (var item in userManager.GetAll())
        {
            Console.WriteLine(item.FirstName);
        }
        Console.WriteLine("Hello, World!");
    }
}