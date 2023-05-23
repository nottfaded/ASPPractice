using Microsoft.AspNetCore.Mvc;
using University.Data.Interfaces;
using University.Data.Models;

namespace University.Data.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly Cart cart;
        //private readonly DBContent dBContent;

        public CartRepository(/*DBContent dBContent*/)
        {
            cart = new Cart();
            /*this.dBContent = dBContent;*/
        }

        public Cart GetCart()
        {
            return cart;
        }

        public void AddProductToCart(Product product)
        {
            var check = cart.Items.FirstOrDefault(i => i.Product.Id == product.Id);

            if(check == null)
            {
                var cartItem = new CartItem { Product = product, Amount = 1 };
                cart.Items.Add(cartItem);
            }
            else
            {
                check.Amount++;
            }
            
        }
        public void RemoveFromCart(int productId)
        {
            var check = cart.Items.FirstOrDefault(i => i.Product.Id == productId);
            if (check != null)
            {
                cart.Items.Remove(check);
            }
        }
        public int GetAllPrice()
        {
            if (cart.Items.Count == 0) return 0;
            return cart.Items.Select(i => i.Product.Price * i.Amount).Sum();
        }
        public void ClearCart()
        {
            cart.Items = new List<CartItem>();
        }
    }
}
