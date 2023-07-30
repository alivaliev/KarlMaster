    using Microsoft.AspNetCore.Mvc;

namespace KarlMaster.WebAPI.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
