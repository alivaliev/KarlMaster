using KarlMaster.Core.Tools.Results.Abstract;
using KarlMaster.Entities.DTOs.ProductDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<ProductAdminListDTO>> GetDashboardProducts(string userId, string langCode);
    }
}
