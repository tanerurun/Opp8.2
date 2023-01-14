﻿using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAll();

        List<Category> GetByCategoryId(int categoryId);
        List<Category> GetByCategoryName(string categoryName);

    }
}
