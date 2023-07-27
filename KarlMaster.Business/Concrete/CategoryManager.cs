using KarlMaster.Business.Abstract;
using KarlMaster.DataAccess.Abstract;
using KarlMaster.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void AddCtegory(Category category)
        {
            _categoryDal.Add(category);
        }

        public void DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetCategories(string langcode)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetNavbarCategories(string langcode)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
