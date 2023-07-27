using KarlMaster.Core.DataAccess.EntityFramework;
using KarlMaster.DataAccess.Abstract;
using KarlMaster.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfRepositoryBase<Product, AppDbContext>, IProductDal
    {
    }
}
