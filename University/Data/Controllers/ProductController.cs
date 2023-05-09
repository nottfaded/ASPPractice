using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using University.Data.Interfaces;
using University.Data.Models;

namespace University.Data.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult Products()
        {
            var products = productRepository.GetProducts();
            var categories = categoryRepository.GetCategories();
            ViewData["Categories"] = categories;
            return View(products);
        }

        public IActionResult Detail(int id)
        {
            var product = productRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["Category"] = categoryRepository.GetCategories().FirstOrDefault(i => i.Id == product.Id);
            return View(product);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Products();
        }

    }
}
