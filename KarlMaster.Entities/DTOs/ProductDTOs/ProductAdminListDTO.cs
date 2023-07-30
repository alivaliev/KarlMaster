using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.Entities.DTOs.ProductDTOs
{
    public class ProductAdminListDTO
    {
        public int Id { get; set; }
        public string  ProductName { get; set; }
        public decimal  Price { get; set; }
        public decimal  Discount { get; set; }
        public string  PhotoUrl { get; set; }
        public int  View { get; set; }
        public string  CategoryName { get; set; }
    }
}
