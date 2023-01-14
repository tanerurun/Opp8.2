using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public List<User> GetByUserId(int userId)
        {
            return _userDal.GetAll(p => p.Id == userId).ToList();
        }

        public List<User> GetByUserName(string userName)
        {
            return _userDal.GetAll(p => p.FirstName == userName).ToList();
        }
    }
}
