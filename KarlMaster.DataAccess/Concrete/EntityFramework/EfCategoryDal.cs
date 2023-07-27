using KarlMaster.Core.DataAccess.EntityFramework;
using KarlMaster.DataAccess.Abstract;
using KarlMaster.Entities.Concrete;
using KarlMaster.Entities.DTOs.CategoryDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfRepositoryBase<Category, AppDbContext>, ICategoryDal
    {
        public List<CategoryHomeListDTO> GetCategoriesByLanguage(string langCode)
        {
            using var context = new AppDbContext();

            var result = context.CategoryLanguages
                .Include(x=>x.Category)
                .Where(x=>x.LangCode == langCode)
                .Select(x=>new CategoryHomeListDTO
                {
                    Id = x.Category.Id,
                    CategoryName = x.CategoryName,
                    SeoUrl = x.SeoUrl,
                    PhotoUrl = x.Category.PhotoUrl,
                    ProductCount = 0
                }).ToList();

            return result;


        }
    }
}
