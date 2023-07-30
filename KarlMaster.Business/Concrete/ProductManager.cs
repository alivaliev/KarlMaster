using KarlMaster.Business.Abstract;
using KarlMaster.Core.Tools.Results.Abstract;
using KarlMaster.DataAccess.Abstract;
using KarlMaster.Entities.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        //public IDataResult<List<ProductAdminListDTO>> GetAdminProducts(string userId, string langCode)
        //{
        //    var result = _productDal.GetProductByUser(userId, langCode);
        //    if (result.Success)
        //    {

        //    }
        //}
    }
}
