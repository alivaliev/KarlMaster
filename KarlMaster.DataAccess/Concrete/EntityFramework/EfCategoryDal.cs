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
        public async Task<bool> AddCategory(CategoryAddDTO categoryAddDTO)
        {
            try
            {
                using var context = new AppDbContext();
                var category = new Category()
                {
                    PhotoUrl = categoryAddDTO.PhotoUrl,
                    IsFeatured = false
                };
                await context.Categories.AddAsync(category);
                await context.SaveChangesAsync();
                for (int i = 0; i < categoryAddDTO.CategoryName.Count; i++)
                {
                    CategoryLanguage cl = new()
                    {
                        CategoryName = categoryAddDTO.CategoryName[i],
                        LangCode = categoryAddDTO.LangCode[i],
                        CategoryId = category.Id,
                        SeoUrl = "ssdsd"
                    };
                    await context.CategoryLanguages.AddAsync(cl);
                }
                await context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

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
