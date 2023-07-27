using KarlMaster.Entities.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Mvc;

namespace KarlMaster.WebUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CategoryAddDTO category)
        {
            return View();
        }
    }
}
