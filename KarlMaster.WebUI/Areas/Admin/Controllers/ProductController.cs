using KarlMaster.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace KarlMaster.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IHttpContextAccessor _contextAccessor;

        public ProductController(IProductService productService, IHttpContextAccessor contextAccessor)
        {
            _productService = productService;
            _contextAccessor = contextAccessor;
        }

        public IActionResult Index()
        {
            var userId = _contextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var result = _productService.GetDashboardProducts(userId,"Az");
            return View(result);
        }
    }
}
