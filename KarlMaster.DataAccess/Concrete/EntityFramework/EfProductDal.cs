using KarlMaster.Core.DataAccess.EntityFramework;
using KarlMaster.Core.Tools.Results.Abstract;
using KarlMaster.Core.Tools.Results.Concrete;
using KarlMaster.DataAccess.Abstract;
using KarlMaster.Entities.Concrete;
using KarlMaster.Entities.DTOs.ProductDTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepositoryBase<Product, AppDbContext>, IProductDal
    {
        public IDataResult<List<ProductAdminListDTO>> GetProductByUser(string userId, string langCode)
        {
            try
            {
                using var context = new AppDbContext();
                var product = context.Products
                    .Include(x => x.Category)
                    .ThenInclude(s => s.CategoryLanguages)
                    .Include(x => x.ProductLanguages)
                    .Include(x => x.Pictures)
                    .Select(data => new ProductAdminListDTO
                    {
                        Id = data.Id,
                        ProductName = data.ProductLanguages.FirstOrDefault(x => x.LangCode == langCode).ProductName,
                        PhotoUrl = data.Pictures.FirstOrDefault().PhotoUrl,
                        Discount = data.Discount,
                        Price = data.Price,
                        View = data.Views,
                        CategoryName = data.Category.CategoryLanguages.FirstOrDefault(x => x.LangCode == langCode).CategoryName
                    }).ToList();

                return new SuccessDataResult<List<ProductAdminListDTO>>(product);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<ProductAdminListDTO>>(ex.Message);
            }


        }


    }
}
