using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAll();
        List<User> GetByUserId(int userId);
        List<User> GetByUserName(string userName);

    }
}
