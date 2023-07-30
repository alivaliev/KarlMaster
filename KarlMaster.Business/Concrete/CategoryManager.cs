using KarlMaster.Business.Abstract;
using KarlMaster.Core.Tools.Results.Abstract;
using KarlMaster.Core.Tools.Results.Concrete;
using KarlMaster.DataAccess.Abstract;
using KarlMaster.Entities.Concrete;
using KarlMaster.Entities.DTOs.CategoryDTOs;
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

        public IResult AddCategory(CategoryAddDTO category)
        {
            try
            {
                _categoryDal.AddCategory(category);
                return new SuccessResult();
                
            }
            catch (Exception ex)
            {
                return new ErrorResult(ex.Message);
            }
        }

        public IResult DeleteCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public IDataResult <List<CategoryHomeListDTO>> GetCategories(string langcode)
        {
            var result = _categoryDal.GetCategoriesByLanguage(langcode);
            return new SuccessDataResult<List<CategoryHomeListDTO>>(result);
        }

        public IDataResult <List<Category>> GetNavbarCategories(string langcode)
        {
            throw new NotImplementedException();
        }

        public IResult UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}
