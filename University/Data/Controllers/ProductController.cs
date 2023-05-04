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
            return View(products);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Products();
        }

    }
}
