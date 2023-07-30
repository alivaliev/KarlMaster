using KarlMaster.Core.Tools.Results.Abstract;
using KarlMaster.Core.Tools.Results.Concrete;
using KarlMaster.Entities.Concrete;
using KarlMaster.Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.Business.Abstract
{
    public interface ICategoryService
    {
        IResult AddCategory(CategoryAddDTO category);
        IResult DeleteCategory(Category category);
        IResult UpdateCategory(Category category);
        IDataResult <List<CategoryHomeListDTO>> GetCategories(string langcode);
        IDataResult <List<Category>> GetNavbarCategories(string langcode);
    }
}
