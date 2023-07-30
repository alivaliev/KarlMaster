using KarlMaster.Core.DataAccess;
using KarlMaster.Core.Tools.Results.Abstract;
using KarlMaster.Entities.Concrete;
using KarlMaster.Entities.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.DataAccess.Abstract
{
    public interface IProductDal : IRepositoryBase<Product>
    {
        IDataResult<List<ProductAdminListDTO>> GetProductByUser(string userId, string langCode);
    }
}
