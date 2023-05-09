using University.Data.Interfaces;
using University.Data.Models;

namespace University.Data.Mocks
{
    public class MockProductRepository : IProductRepository
    {
        private List<Product> products;

        public MockProductRepository()
        {
            products = new List<Product>()
            {
                new Product { Id = 1, Name = "Mонітор Gigabyte 23.8\" G24F Gaming Black", Description = "Діагональ: 23.8″\r\nРоздільна здатність: 1920x1080\r\nТип матриці: SS-IPS\r\nЧастота оновлення: 165 Гц\r\nЧас відгуку: 1 мс\r\nЯскравість: 300 кд/м²\r\nСпіввідношення сторін: 16:9", Price = 7999.00m, CategoryId = 1, ImageUrl = "/img/gigabyte-238-g24f-gaming-black.png", CountInStock = 10 },
                new Product { Id = 2, Name = "Миша Logitech G102 Lightsync", Description = "Призначення: Для геймінгу\r\nПідключення: Дротове\r\nІнтерфейс підключення: USB\r\nЧутливість: 200–8000 dpi\r\nТип мишки: Оптична (світлодіодна)\r\nКількість кнопок: 6 кнопок\r\nЖивлення: Від порту USB", Price = 999.00m, CategoryId = 2, ImageUrl = "/img/logitech-g102-lightsync-910-005823-black.png", CountInStock = 15 },

            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }

        public void AddProduct(Product product)
        {
            product.Id = products.Count + 1;
            products.Add(product);
        }

        public void UpdateProduct(Product product)
        {
            var index = products.FindIndex(p => p.Id == product.Id);
            if (index >= 0)
            {
                products[index] = product;
            }
        }

        public void DeleteProduct(int id)
        {
            var index = products.FindIndex(p => p.Id == id);
            if (index >= 0)
            {
                products.RemoveAt(index);
            }
        }
    }
}
