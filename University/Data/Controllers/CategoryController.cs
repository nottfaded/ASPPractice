using Microsoft.AspNetCore.Mvc;
using University.Data.Interfaces;
using University.Data.Models;

namespace University.Data.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public IActionResult Categories()
        {
            var categories = categoryRepository.GetCategories();
            return View(categories);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Categories();
        }
    }
}
