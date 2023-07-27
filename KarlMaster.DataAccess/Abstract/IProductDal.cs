using KarlMaster.Core.DataAccess;
using KarlMaster.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.DataAccess.Abstract
{
    public interface IProductDal : IRepositoryBase<Product>
    {
    }
}
