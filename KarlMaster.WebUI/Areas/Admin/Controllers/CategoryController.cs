using KarlMaster.Business.Abstract;
using KarlMaster.Entities.DTOs.CategoryDTOs;
using Microsoft.AspNetCore.Mvc;

namespace KarlMaster.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

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
            var result = _categoryService.AddCategory(category);
            if (result.Success)
            {
            return RedirectToAction("Index");

            }
            return View(category);
        }
    }
}
