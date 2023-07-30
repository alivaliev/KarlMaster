using KarlMaster.Core.DataAccess;
using KarlMaster.Entities.Concrete;
using KarlMaster.Entities.DTOs.CategoryDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.DataAccess.Abstract
{
    public interface ICategoryDal : IRepositoryBase<Category>
    {
        List<CategoryHomeListDTO> GetCategoriesByLanguage(string langCode);
        Task<bool> AddCategory(CategoryAddDTO categoryAddDTO);
    }
}
