using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using University.Data.Interfaces;
using University.Data.Models;
using University.Data.Repository;

namespace University.Data.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }

        public JsonResult Carts()
        {
            return Json(cartRepository.GetCart());
        }

        public IActionResult RemoveFromCart(int id)
        {
            cartRepository.RemoveFromCart(id);
            return Ok();
        }

        [HttpGet(Name = "Check")]
        public IActionResult Check()
        {
            return Carts();
        }

        public IActionResult Order()
        {
            ViewData["FullPrice"] = cartRepository.GetAllPrice();
            return View();
        }

        [HttpPost]
        public IActionResult PlaceOrder(OrderViewModel order)
        {
            var fullPrice = cartRepository.GetAllPrice();
            if (ModelState.IsValid)
            {
                cartRepository.ClearCart();
                return View("OrderConfirmation", new OrderConfirmationViewModel(order, fullPrice));
            }

            ViewData["FullPrice"] = fullPrice;
            return View("Order", order);
        }

        public IActionResult OrderConfirmation(OrderConfirmationViewModel model)
        {
            return View(model);
        }

        public record OrderConfirmationViewModel(OrderViewModel order, int fullPrice);
    }
}
