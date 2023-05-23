using University.Data.Models;

namespace University.Data.Interfaces
{
    public interface ICartRepository
    {
        Cart GetCart();
        void AddProductToCart(Product product);
        void RemoveFromCart(int productId);
        int GetAllPrice();
        void ClearCart();
    }
}
