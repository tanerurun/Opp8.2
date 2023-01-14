using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetByCategoryId(int categoryId)
        {
            return _categoryDal.GetAll(p => p.CategoryId == categoryId).ToList();
            //return _productDal.GetAll(p => p.CategoryId == categoryId).ToList();

        }

        public List<Category> GetByCategoryName(string categoryName)
        {
            return _categoryDal.GetAll(p => p.CategoryName == categoryName).ToList();
        }
    }
}
