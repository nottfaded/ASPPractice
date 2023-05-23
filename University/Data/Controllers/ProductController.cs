using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Web.Helpers;
using University.Data.Interfaces;
using University.Data.Models;

namespace University.Data.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository productRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly ICartRepository cartRepository;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, ICartRepository cartRepository)
        {
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
            this.cartRepository = cartRepository;
        }

        public IActionResult Products()
        {
            var products = productRepository.GetProducts();
            var categories = categoryRepository.GetCategories();
            var cart = cartRepository.GetCart();
            ViewData["Categories"] = categories;
            ViewData["CountCartItem"] = cart.Items.Count;
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

        public IActionResult AddToCart(int id)
        {
            var product = productRepository.GetProductById(id);
            if(product == null)
            {
                return NotFound();
            }

            cartRepository.AddProductToCart(product);
            var countCartItem = cartRepository.GetCart().Items.Count;
            ViewData["CountCartItem"] = countCartItem;

            return Ok(countCartItem);
        }

        public IActionResult Cart()
        {
            ViewData["Categories"] = categoryRepository.GetCategories();
            ViewData["FullPrice"] = cartRepository.GetAllPrice();
            return View(cartRepository.GetCart().Items);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Products();
        }


    }
}
