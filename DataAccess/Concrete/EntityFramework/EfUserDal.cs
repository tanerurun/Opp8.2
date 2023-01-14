using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        public void Add(User entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Add(entity);
                addedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(User entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<User>().SingleOrDefault(filter);
            }
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<User>().ToList()
                    : context.Set<User>().Where(filter).ToList();
            }
        }

        public void Update(User entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var updatetedEntity = context.Entry(entity);
                updatetedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
